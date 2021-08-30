# Azure Container Instances - Container Group

[Container groups in Azure Container Instances](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-container-groups)

## Demo

Uses FoodApp from [https://github.com/arambazamba/FoodApp](https://github.com/arambazamba/FoodApp)

- Explain `foodapp-container-grp.yaml`
- Run `create-container-group.azcli`
- Use vi to change `/usr/share/nginx/html/assets/app-config.json` to point to correct api endpoint. In a real world deployment this could be done as part of a file replacement in the DevOps pipeline.