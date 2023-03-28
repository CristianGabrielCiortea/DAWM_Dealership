using DataLayer.Dtos;

namespace DataLayer.Mapping
{
    public static class SalesmanMappingExtensions
    {
        public static List<SalesmanDto> ToSalesmanDtos(this List<SalesmanDto> salesmen)
        {
            var results = salesmen.Select(e => e.ToSalesmanDto()).ToList();

            return results;
        }

        public static SalesmanDto ToSalesmanDto(this SalesmanDto salesmanDto)
        {
            if (salesmanDto == null) return null;

            var result = new SalesmanDto();
            result.FirstName = salesmanDto.FirstName;
            result.LastName = salesmanDto.LastName;
            result.DateOfBirth = salesmanDto.DateOfBirth;
            result.Address = salesmanDto.Address;

            return result;
        }
    }
}