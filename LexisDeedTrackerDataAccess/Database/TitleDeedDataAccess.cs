using Dapper;
using LexisDeedTrackerDataAccess.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexisDeedTrackerDataAccess.Database
{
    public class TitleDeedDataAccess : ITitleDeedDataAccess
    {
        private readonly DBContext context;

        public TitleDeedDataAccess(DBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<TitleDeed>> GetTitleDeeds()
        {
            var query = @"SELECT TOP 100 TD.[TitleDeedId]      
                            ,TD.[Notes]
                            ,TD.[DateLodged]
                            ,TD.[DateProcessed]
                            ,TD.[TMStamp]
                            ,PO.OwnerID
                            ,PO.[IDNumber]
                            ,PO.[FirstName]
                            ,PO.[Surname]
                            ,PO.[CellNumber]
                            ,PA.OwnerID
                            ,PA.[AddressID]
                            ,PA.[ERFNumber]
                            ,PA.[StreetNo]
                            ,PA.[StreetName]
                            ,PA.[ComplexName]
                            ,PA.[SurburbName]
                            ,PA.[City]
                            ,PA.[Province]
                            ,PA.[PostalCode]
                        FROM TitleDeed TD
                        INNER JOIN PropertyOwner PO
                            on TD.OwnerID = PO.OwnerID
                    INNER JOIN PropertyAddress PA
                            ON PO.OwnerID = PA.OwnerID
";

            using (var connection = context.CreateConnection())
            {
                return await connection.QueryAsync<TitleDeed, PropertyOwner, PropertyAddress, TitleDeed>(query, 
                map: (titleDeed, propertyOwner, propertyAddress) =>
                {
                    titleDeed.PropertyOwner = propertyOwner;
                    titleDeed.PropertyOwner.PropertyAddress = propertyAddress;
                    return titleDeed;
                },
                splitOn: "OwnerID");
            }
        }

        public async Task<TitleDeed> GetTitleDeed(int? id)
        {
            var query = @"SELECT TOP 100 TD.[TitleDeedId]      
                            ,TD.[Notes]
                            ,TD.[DateLodged]
                            ,TD.[DateProcessed]
                            ,TD.[TMStamp]
                            ,PO.OwnerID
                            ,PO.[IDNumber]
                            ,PO.[FirstName]
                            ,PO.[Surname]
                            ,PO.[CellNumber]
                            ,PA.OwnerID
                            ,PA.[AddressID]
                            ,PA.[ERFNumber]
                            ,PA.[StreetNo]
                            ,PA.[StreetName]
                            ,PA.[ComplexName]
                            ,PA.[SurburbName]
                            ,PA.[City]
                            ,PA.[Province]
                            ,PA.[PostalCode]
                        FROM TitleDeed TD
                        INNER JOIN PropertyOwner PO
                            on TD.OwnerID = PO.OwnerID
                    INNER JOIN PropertyAddress PA
                            ON PO.OwnerID = PA.OwnerID
                    WHERE TitleDeedId = @Id";

            using (var connection = context.CreateConnection())
            {
                var result = await connection.QueryAsync<TitleDeed, PropertyOwner, PropertyAddress, TitleDeed>(query,
                map: (titleDeed, propertyOwner, propertyAddress) =>
                {
                    titleDeed.PropertyOwner = propertyOwner;
                    titleDeed.PropertyOwner.PropertyAddress = propertyAddress;
                    return titleDeed;
                }, new { Id = id },
                splitOn: "OwnerID");
                    return result.FirstOrDefault();
            }
        }

    }
}
