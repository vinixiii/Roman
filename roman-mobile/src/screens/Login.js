import React from "react";
import { StyleSheet, Text, View, Image, TextInput, Button, Alert, TouchableOpacity } from "react-native";
import { BordaTopo } from "../assets/images/BordaTopo";
import { BordaBaixo } from "../assets/images/BordaBaixo";
export function Login() {
    return (

        <View style={styles.login__body}>
            <BordaTopo style={styles.login__img} />
                <Image
                    source={require("../assets/images/logo1.svg")}
                    style={styles.login__logo}
                />
            <View style={styles.login__main}>
                <Text style={styles.login__text1}>E-mail</Text>
                <TextInput
                    style={styles.login__input}
                />
                <Text style={styles.login__text1}>Senha</Text>
                <TextInput
                    style={styles.login__input}
                />

                <TouchableOpacity style={styles.login__button}>
                    <Text style={styles.buttonText}>Entrar</Text>
                </TouchableOpacity>

            </View>
           
<BordaBaixo style={styles.login__img2} />
            


           


        </View>

    );
}

const styles = StyleSheet.create({

    login__body: {
        flex: 1,
        // backgroundColor: 'red',
    },

    login__text: {
        margin: "auto"

    },

   

    login__text1: {
        color: '#33547D',

    },

    login__logo: {
        height: 70,
        resizeMode: 'contain',
       

    },

    login__main: {
        padding: 20,
        paddingLeft: 20,
        marginTop: 60,
        marginBottom: 'auto',
        // backgroundColor: 'green',

    },

    login__button: {

        height: 40,
        width: 89,
        justifyContent: 'center',
        alignSelf: 'flex-end',
        backgroundColor: '#49A2C2',
        borderRadius: 6,


    },

    buttonText: {
        textAlign: 'center',
        color: 'white',

    },


    login__input: {

        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 1,
        },
        shadowOpacity: 0.22,
        shadowRadius: 2.22,
        elevation: 3,
        height: 40,
        marginBottom: 25,

    },


    login__img: {

        height: 119,
        // backgroundColor: 'pink',
    },

    login__img2: {
       
        height: 119,
        // backgroundColor: 'pink',
        alignSelf: 'flex-end',
        position: 'absolute',
        bottom: 0,
        
        
       
       
    },


});