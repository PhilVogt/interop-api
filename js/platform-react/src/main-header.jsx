const MainHeader = () => {
    const style = {
        inlineSize: "fit-content",
        margin: "auto",
        textAlign: "center",
        padding: "25px"
    }
    return <div style={style}>
        <span>
            (http://localhost:4101)
        </span>
        <div style={{ padding: "5px" }}>
            <button style={{ background: "gray" }}>Flow</button>
            <button style={{ background: "gray" }}>Axe</button>
            <button style={{ background: "gray" }}>Client</button>
        </div>
        <span>
            Section below is handled by Platform API
        </span>
    </div>;
};

export default MainHeader;