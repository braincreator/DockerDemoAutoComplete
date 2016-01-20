FROM microsoft/aspnet

RUN apt-get update
RUN apt-get install curl -y
RUN apt-get install software-properties-common -y
RUN add-apt-repository ppa:chris-lea/node.js
RUN apt-get update
RUN apt-get install nodejs -y
RUN curl -L https://www.npmjs.com/install.sh | sh
RUN npm install --global gulp -y

EXPOSE 5005

COPY project.json /app/  
WORKDIR /app  
RUN ["dnu", "restore"]
COPY . /app  

CMD ["cd", "/app/"]
CMD ["npm", "install"]
CMD ["bower", "install"]

ENTRYPOINT ["dnx", "-p", "project.json", "web"]

