# es.jacksparrot.json unity package

## Installation using the Unity Package Manager (Unity 2018.1+)

The [Unity Package Manager](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@1.8/manual/index.html) (UPM) is a new method to manage external packages. It keeps package contents separate from your main project files.

1. Modify your project's `Packages/manifest.json` file adding this line:

    ```json
    "es.jacksparrot.json": "https://github.com/JackSParrot/json-pkg.git"
    ```

    Make sure it's still a valid JSON file. For example:

    ```json
    {
        "dependencies": {
            "com.unity.ads": "2.0.8",
            "es.jacksparrot.json": "https://github.com/JackSParrot/json-pkg.git"
        }
    }
    ```

2. To update the package you need to delete the package lock entry in the `lock` section in `Packages/manifest.json`. The entry to delete could look like this:

    ```json
      "es.jacksparrot.json": {
      "hash": "31fe84232fc9f9c6e9606dc9e5a285886a94f26b",
      "revision": "package"
    }
    ```
