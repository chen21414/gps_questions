//#2
function sortByPriceAscending(jsonString) {
  const json = JSON.parse(jsonString);
  json.sort((a, b) => {
    if (a.price > b.price) return 1; //+1 means above
    else if (a.price < b.price) return -1; //-1 means under it

    if (a.name > b.name) return 1; //if the price is the same, check the name
    else return -1;
  });
  return JSON.stringify(json);
  // Yоur cоdе gоеs hеrе
}

console.log(
  sortByPriceAscending(
    '[{"name":"eggs","price":1},{"name":"coffee","price":9.99},{"name":"rice","price":4.04}]'
  )
);
