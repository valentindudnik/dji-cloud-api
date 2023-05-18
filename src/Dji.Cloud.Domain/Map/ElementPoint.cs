namespace Dji.Cloud.Domain.Map;

public class ElementPoint : ElementType
{
    public ElementPoint(string type) : base(type)
    {
    }

    //    private Double[] coordinates;

    //    public ElementPointDTO()
    //    {
    //        super(ElementTypeEnum.POINT.getDesc());
    //    }

    //    @Override
    //public List<ElementCoordinateDTO> convertToList()
    //    {
    //        List<ElementCoordinateDTO> coordinateList = new ArrayList<>();
    //        coordinateList.add(ElementCoordinateDTO.builder()
    //                .longitude(this.coordinates[0])
    //                .latitude(this.coordinates[1])
    //                .altitude(this.coordinates.length == 3 ? this.coordinates[2] : null)
    //                .build());
    //        return coordinateList;
    //    }

    //    @Override
    //public void adapterCoordinateType(List<ElementCoordinateDTO> coordinateList)
    //    {
    //        if (CollectionUtils.isEmpty(coordinateList))
    //        {
    //            return;
    //        }
    //        this.coordinates = new Double[]{
    //            coordinateList.get(0).getLongitude(),
    //            coordinateList.get(0).getLatitude(),
    //            coordinateList.get(0).getAltitude()
    //    };
    //    }

    public override Task AdapterCoordinateTypeAsync(IEnumerable<ElementCoordinate> coordinates)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<ElementCoordinate>> ConvertToAsync()
    {
        throw new NotImplementedException();
    }
}