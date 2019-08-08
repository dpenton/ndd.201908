# ndd.201908

git@github.com:dpenton/ndd.201908.git

git pull
git checkout -b feature/meeting2.2	# or meeting2.1
dotnet new --help

dotnet new webapi -o Site
dotnet new xunit -o Tests.Site
dotnet new sln
dotnet sln ndd.201908 add Site Tests.Site


dotnet publish Site/Site.csproj -c Release --self-contained -r win-x64
dotnet publish Site/Site.csproj -c Release --self-contained -r osx-x64

dotnet run --server.urls http://0.0.0.0:5000
On mac
	sudo chmod +x Site
	open Site

Some explanations on why you should not dispose of HttpClient:
https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/
https://medium.com/@nuno.caneco/c-httpclient-should-not-be-disposed-or-should-it-45d2a8f568bc

HttpClientFactory:
https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests

Use Lamar for IoC needs:
https://jasperfx.github.io/lamar/documentation/ioc/
