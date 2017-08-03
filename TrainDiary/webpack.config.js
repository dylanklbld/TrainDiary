const path = require('path')
var HTMLWebpackPlugin = require('html-webpack-plugin');

var HTMLWebpackPluginConfig = new HTMLWebpackPlugin({
        template: __dirname + '/app/index.html',
        filename: 'index.html',
        inject: 'body'
});

const paths = {
    outputDir: './wwwroot/dist'
};

module.exports = {
    entry: __dirname + '/app/index.js',
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
        filename: 'transformed.js',
        path: path.join(__dirname, paths.outputDir)
    },
    stats: {
            colors: true,
            modules: true,
            reasons: true,
            errorDetails: true
    },
    plugins: [HTMLWebpackPluginConfig]     
};