
# Running demo:
### Development

In the first terminal:
```
cd front-end
npm run serve
```

In the second terminal:
```
electronize start
```

### Production

1. Open `electron.net-vue.csproj` and uncomment the piece under "UNCOMMENT FOR PRODUCTION"
2. Open `Startup.cs` and comment out the piece under "COMMENT FOR PRODUCTION"
3. Follow instructions at [Electron.NET #Build](https://github.com/ElectronNET/Electron.NET/blob/master/README.md#build)  
(for example run `electronize build /target win`)


# Further work

Feel free to replace vue app in `front-end` directory with your
own configuration

```bash
rm -r front-end
vue create -n front-end
```

