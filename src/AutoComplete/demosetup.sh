cd ..
cd ..
cd ..
sudo rm -rf demo/
sudo git clone https://github.com/braincreator/DockerDemoAutoComplete /demo
cd /demo/src/AutoComplete
docker build -t gcr.io/containerdemo-1190/acdemo .
gcloud docker push gcr.io/containerdemo-1190/acdemo
kubectl delete services acdemo
kubectl get services
kubectl delete rc acdemo
kubectl run acdemo --image=gcr.io/containerdemo-1190/acdemo --port=5005
kubectl expose rc acdemo --type="LoadBalancer"
sleep 1m
kubectl get services
cd ..
cd ..
sudo rm -rf demo/
