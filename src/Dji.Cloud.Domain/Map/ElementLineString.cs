namespace Dji.Cloud.Domain.Map;

public class ElementLineString : ElementType
{
    public ElementLineString(string type) : base(type)
    {
    }

    //private Double[][] coordinates;

    //public ElementLineStringDTO()
    //{
    //    super(ElementTypeEnum.LINE_STRING.getDesc());
    //}

    //@Override
    //public List<ElementCoordinateDTO> convertToList()
    //{
    //    List<ElementCoordinateDTO> coordinateList = new ArrayList<>();
    //    for (Double[] coordinate : this.coordinates)
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
    //    this.coordinates = new Double[coordinateList.size()][2];
    //    for (int i = 0; i < this.coordinates.length; i++)
    //    {
    //        this.coordinates[i][0] = coordinateList.get(i).getLongitude();
    //        this.coordinates[i][1] = coordinateList.get(i).getLatitude();
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
