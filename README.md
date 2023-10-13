# newStart

 - [Logs in Kibana](https://kibana.prd.travix.com/app/kibana#/discover?_g=()&_a=(columns:!(loglevel,messagetype,message),index:'550ed320-893f-11e8-968b-33997cc06b41',interval:auto,query:(language:lucene,query:'source.appname:foo'),sort:!(_score,desc)))
 - [Grafana dashboard](https://grafana-production.travix.com/d/TrGPEtamz/asp-net-core-app-wip?var-app=foo)
 - [Estafette CI/CD](https://estafette.travix.com/pipelines/bitbucket.org/xivart/newstart)

## Development

### Run

```cmd
dotnet build
cd src/newStart.WebService
dotnet run
```
