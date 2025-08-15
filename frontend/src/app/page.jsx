export default async function Home() {

  const data = await fetch(`${process.env.NEXT_PUBLIC_API_URL}/Products`);
  const products = await data.json();

  console.log("API URL:", process.env.NEXT_PUBLIC_API_URL);
  console.log(data,products);

  return (
    <div>
      {products.map(x => (
        <div>
          <h2>{x.name}</h2>
          <h3>{x.price}</h3>
        </div>
      ))}
     
    </div>
  );
}
