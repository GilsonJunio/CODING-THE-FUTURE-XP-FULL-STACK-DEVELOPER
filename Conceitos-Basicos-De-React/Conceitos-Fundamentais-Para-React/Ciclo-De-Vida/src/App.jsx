import react, { useState,useEffect} from 'react'





const App = () =>{
	const [usuario, setUsuario] = useState("")
	const [usuarios, setUsuarios] = useState(["Pablo","José","Manoel"])
	const [count, setCount] = useState(0)

	useEffect(()=>{
		setCount(usuarios.length)
		return () => handleOffline()
	},[usuarios])

	const handleAddUser = () => {
		setUsuarios([...usuarios,usuario])
		setUsuario("")
	}


	return(
		<div className="App">
			<h1>Hello DIO</h1>
			<h3>Total: {count}</h3>

			<div>
				<input value={usuario} onChange={(event) => setUsuario(event.target.value)}></input>
				<button onClick={handleAddUser}>Adicionar</button>

			</div>
			<hr />
			{
				usuarios.map((item)=>(
				 <p>{item}</p>
				 ))
			}

		</div>

	)
}
export default App;