node{
	timestamps{
		stage("Clean WS"){
			cleanWs()
			checkout scm
		}

		stage("Hello world"){
			echo 'Hello world!'
		}
	}
}