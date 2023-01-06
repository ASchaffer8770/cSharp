﻿using HeroExplorer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using static HeroExplorer.Models.CharacterDataWrapper;

namespace HeroExplorer
{
    public class MarvelFacade
    {
        private const string PrivateKey = "1688654c0be7d6ca6bafa76c4d6e216e";
        private const string PublicKey = "29f67a991173cd72b752933506c458b6c4ef9d0b";
        private const int MaxCharacters = 1500;
        private const string ImageNotAvailablePath = "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available";

        public static async Task PopulateMarvelCharacters(ObservableCollection<Character> marvelCharacters)
        {
            var characterDataWrapper = await GetCharacterDataWrapper();
            var characters = characterDataWrapper.data.results;

            foreach ( var character in characters )
            {
                //filter characters that are missing thumbnail images

                if (character.thumbnail != null
                    && character.thumbnail.path != ""
                    && character.thumbnail.path != ImageNotAvailablePath)
                {

                    marvelCharacters.Add(character);
                }
            }

        }

        public async static Task<CharacterDataWrapper> GetCharacterDataWrapper()
        {
            //Assemble the URL
            Random random = new Random();
            var offset = random.Next(MaxCharacters);


            //Get the MD5 Hash
            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = CreateHash(timeStamp);


            string url = String.Format("https://gateway.marvel.com:443/v1/public/characters?limit=10&offset={0}&apikey={1}&ts={2}&hash={3}", offset, PublicKey, timeStamp);


            //Call out to Marvel
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> String / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (CharacterDataWrapper)serializer.ReadObject(ms);
            return result;

        }

        private static string CreateHash(string timeStamp)
        {
            var toBeHashed = timeStamp + PrivateKey + PublicKey;
            var hashedMessage = ComputeMD5(toBeHashed);
            return hashedMessage;
        }

        //MD5 HASH CREATION
        private static string ComputeMD5( string str )
        {
            var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buff = CryptographicBuffer.ConvertStringToBinary(str, BinaryStringEncoding.Utf8);
            var hashed = alg.HashData(buff);
            var res = CryptographicBuffer.EncodeToHexString(hashed);
            return res;
        }
    }
}
