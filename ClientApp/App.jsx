import { useState, useEffect } from 'react';

function App() {
  const [query, setQuery] = useState('');
  const [results, setResults] = useState([]);

  // Function to fetch search results
  const fetchSearchResults = async () => {
    try {
      const response = await fetch(`/api/things/search?query=${query}`);
      const data = await response.json();
      setResults(data);
    } catch (error) {
      console.error("Error fetching data: ", error);
      setResults([]);
    }
  };

  // useEffect to call fetchSearchResults when query changes
  useEffect(() => {
    if (query.length > 0) {
      fetchSearchResults();
    } else {
      setResults([]);
    }
  }, [query]);

  return (
    <>
      <div>
        <h1>Demo</h1>
        <h2>Things</h2>
        <input 
          type="text" 
          value={query}
          onChange={(e) => setQuery(e.target.value)}
        />
        {query.length > 0 && results.length > 0 && (
            <p>You searched for <strong>{query}</strong>, we found <strong>{results.length}</strong> things.</p>
        )}
        {query.length > 0 && results.length == 0 && (
            <p>Your search for <div dangerouslySetInnerHTML={{__html: query}} /> did not return any things.</p>
        )}
        {query.length == 0 && (
            <p>Type something to find something.</p>
        )}
        <hr />
        <ul>
          {results.map((item, index) => (
            <li key={index}>
              <h3>{item.name}</h3>
              <p>{item.description}</p>
            </li>
          ))}
        </ul>
      </div>
    </>
  );
}

export default App;
