public record CategoryDto{
  public int Id { get; set; }
  public string Name { get; set; }
  public List<ProductDto>? Products { get; set; }
};

