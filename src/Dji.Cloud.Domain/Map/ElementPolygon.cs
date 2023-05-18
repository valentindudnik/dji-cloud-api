namespace Dji.Cloud.Domain.Map;

public class ElementPolygon : ElementType
{
    public ElementPolygon(string type) : base(type)
    {
    }

    //private Double[][][] coordinates;

    //public ElementPolygonDTO()
    //{
    //    super(ElementTypeEnum.POLYGON.getDesc());
    //}

    //@Override
    //public List<ElementCoordinateDTO> convertToList()
    //{
    //    List<ElementCoordinateDTO> coordinateList = new ArrayList<>();

    //    for (Double[] coordinate : this.coordinates[0])
    //    {
    //        coordinateList.add(ElementCoordinateDTO.builder()
    //                .longitude(coordinate[0])
    //                .latitude(coordinate[1])
    //                .build());
    //    }
    //    return coordinateList;
    //}

    //@Override
    //public void adapterCoordinateType(List<ElementCoordinateDTO> coordinateList)
    //{
    //    if (CollectionUtils.isEmpty(coordinateList))
    //    {
    //        return;
    //    }
    //    this.coordinates = new Double[1][coordinateList.size()][2];
    //    for (int i = 0; i < this.coordinates[0].length; i++)
    //    {
    //        this.coordinates[0][i][0] = coordinateList.get(i).getLongitude();
    //        this.coordinates[0][i][1] = coordinateList.get(i).getLatitude();
    //    }
    //}

    public override Task AdapterCoordinateTypeAsync(IEnumerable<ElementCoordinate> coordinates)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<ElementCoordinate>> ConvertToAsync()
    {
        throw new NotImplementedException();
    }
}
