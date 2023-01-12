using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using truthordrink.Model;

namespace truthordrink.Logic
{
    public class CocktailLogic
    {
        public async static Task<List<Cocktail>> GetCocktailsByName(string name)
        {
            List<Cocktail> cocktails = new List<Cocktail>();

            var url = Cocktail.GenerateURLName(name);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var cocktailByNameResponse = JsonConvert.DeserializeObject<CocktailByNameResponse>(json);
                //cocktails = cocktailByNameResponse.Drinks as List<Drink>;
            }

            return cocktails;
        }
    }
}
