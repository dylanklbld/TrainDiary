var CleanWebpackPlugin = require('clean-webpack-plugin');
let path = require('path');
const bundleFolder = "wwwroot/build/";


module.exports = {
    entry:'./Scripts/index.js', 
    module:{
        loaders:[
            {
                test: /\.js$/,
                exclude: [/node_modules/],
                loader: 'babel-loader'
            },
            {
                test: /\.css$/,
                loader: "style-loader!css-loader"
            }
        ]
    },
    output:{
        filename: 'index.js',
        path:  path.resolve(__dirname, bundleFolder)
    },
    stats: {
            colors: true,
            modules: true,
            reasons: true,
            errorDetails: true
    },
    plugins: [ new CleanWebpackPlugin([bundleFolder])]     
};