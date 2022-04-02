node{
	timestamps{
		stage("Clean WS"){
			cleanWs()
			checkout scm
		}
	}
}