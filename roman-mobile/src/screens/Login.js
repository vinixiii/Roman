//Packages
import React, { useState } from "react";
import {
  StyleSheet,
  Text,
  View,
  Image,
  TextInput,
  TouchableOpacity,
} from "react-native";
import AsyncStorage from "@react-native-async-storage/async-storage";

//Services
import api from "../services/api";

//Images
import { BordaTopo } from "../assets/images/BordaTopo";
import { BordaBaixo } from "../assets/images/BordaBaixo";

//Components
import { Button } from "../components/Button";

//figueiroa@email.com senha123

export function Login({ navigation }) {
  const [email, setEmail] = useState("");
  const [pwd, setPwd] = useState("");

  async function signIn() {
    try {
      if (email.trim() === "" || pwd.trim() === "") {
        return;
      }

      const res = await api.post("/login", {
        email: email,
        senha: pwd,
      });

      const token = res.data.token;

      await AsyncStorage.setItem("token", token);

      navigation.navigate("Navigation");
    } catch (error) {
      console.warn(error);
    }
  }

  return (
    <View style={styles.login__body}>
      <BordaTopo style={styles.login__img} />
      {/* <Image
            source={require("../assets/images/logo1.svg")}
            style={styles.login__logo}
        /> */}
      <View style={styles.login__main}>
        <View style={styles.formField}>
          <Text style={styles.formLabel}>E-mail</Text>
          <TextInput
            style={styles.formInput}
            // keyboardType="email-address"
            onChangeText={(email) => setEmail(email)}
          />
        </View>

        <View style={styles.formField}>
          <Text style={styles.formLabel}>Senha</Text>
          <TextInput
            style={styles.formInput}
            // keyboardType="email-address"
            onChangeText={(pwd) => setPwd(pwd)}
          />
        </View>
      </View>

      <Button onPress={signIn}>Entrar</Button>

      {/* <BordaBaixo style={styles.login__img2} /> */}
    </View>
  );
}

const styles = StyleSheet.create({
  login__body: {
    flex: 1,
  },

  login__text: {
    margin: "auto",
  },

  login__text1: {
    color: "#33547D",
  },

  login__logo: {
    height: 70,
    resizeMode: "contain",
  },

  login__main: {
    padding: 20,
    paddingLeft: 20,
    marginTop: 60,
    marginBottom: "auto",
  },

  login__button: {
    height: 40,
    width: 89,
    justifyContent: "center",
    alignSelf: "flex-end",
    backgroundColor: "#49A2C2",
    borderRadius: 6,
  },

  buttonText: {
    textAlign: "center",
    color: "white",
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
  },

  login__img2: {
    height: 119,
    alignSelf: "flex-end",
    position: "absolute",
    bottom: 0,
  },

  formField: {
    marginBottom: 20,
  },

  formLabel: {
    fontSize: 18,
    color: "#33547D",
    marginBottom: 8,
  },

  formInput: {
    backgroundColor: "#fff",
    borderRadius: 6,
    height: 60,
    paddingLeft: 20,
  },
});
