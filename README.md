# DockerDemoAutoComplete
Steps to get docker image:</br>
<b>1. Clone repository of app (docker image)</b></br>
<code>sudo git clone https://github.com/braincreator/DockerDemo.git AutoComplete/</code></br>
<b>2. Change directory to just cloned repo folder</b></br>
<code>cd AutoComplete/src/AutoComplete</code></br>
<b>3. Build docker image</b></br>
<code>docker build -t myapp .</code></br>
<b>4. Run docker container with newly created image</b></br>
<code>docker run -t -d -p 5005:5005 myapp</code></br>
<b>5. That's it. Now you can see your app at localhost:5005 (localhost on host machine i.e. linux vm)</b>
