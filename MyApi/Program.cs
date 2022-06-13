using MyApi;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) =>
{
    using (DataBase db = new DataBase()) 
    {
        Goods_Type goods_type = new Goods_Type() { duty_for_unit = 5, name = "Сигареты", unit = "Пачка"};
        db.goods_Types.Add(goods_type);
        db.SaveChanges();
        var good = db.goods_Types;

        foreach (Goods_Type g in good) 
        {
            Console.WriteLine(g.name);
        }
    }
});

app.Run();
