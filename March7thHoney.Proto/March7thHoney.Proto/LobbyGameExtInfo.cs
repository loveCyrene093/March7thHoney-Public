using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyGameExtInfo : IMessage<LobbyGameExtInfo>, IMessage, IEquatable<LobbyGameExtInfo>, IDeepCloneable<LobbyGameExtInfo>, IBufferMessage
{
	public enum JNJJJGBCEDGOneofCase
	{
		None = 0,
		LobbyMarchInfo = 1001,
		LobbyMarbleInfo = 1002,
		NIFBKKNFKEG = 1003,
		LobbyGridFightInfo = 1004,
		PCFNJJCOJED = 1005
	}

	private static readonly MessageParser<LobbyGameExtInfo> _parser = new MessageParser<LobbyGameExtInfo>(() => new LobbyGameExtInfo());

	private UnknownFieldSet _unknownFields;

	public const int BHILEPGIFNEFieldNumber = 1;

	private static readonly FieldCodec<string> _repeated_bHILEPGIFNE_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> bHILEPGIFNE_ = new RepeatedField<string>();

	public const int HMPCFJPJDOEFieldNumber = 2;

	private bool hMPCFJPJDOE_;

	public const int LobbyMarchInfoFieldNumber = 1001;

	public const int LobbyMarbleInfoFieldNumber = 1002;

	public const int NIFBKKNFKEGFieldNumber = 1003;

	public const int LobbyGridFightInfoFieldNumber = 1004;

	public const int PCFNJJCOJEDFieldNumber = 1005;

	private object jNJJJGBCEDG_;

	private JNJJJGBCEDGOneofCase jNJJJGBCEDGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyGameExtInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyGameExtInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> BHILEPGIFNE => bHILEPGIFNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HMPCFJPJDOE
	{
		get
		{
			return hMPCFJPJDOE_;
		}
		set
		{
			hMPCFJPJDOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarchInfo LobbyMarchInfo
	{
		get
		{
			if (jNJJJGBCEDGCase_ != JNJJJGBCEDGOneofCase.LobbyMarchInfo)
			{
				return null;
			}
			return (LobbyMarchInfo)jNJJJGBCEDG_;
		}
		set
		{
			jNJJJGBCEDG_ = value;
			jNJJJGBCEDGCase_ = ((value != null) ? JNJJJGBCEDGOneofCase.LobbyMarchInfo : JNJJJGBCEDGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyMarbleInfo LobbyMarbleInfo
	{
		get
		{
			if (jNJJJGBCEDGCase_ != JNJJJGBCEDGOneofCase.LobbyMarbleInfo)
			{
				return null;
			}
			return (LobbyMarbleInfo)jNJJJGBCEDG_;
		}
		set
		{
			jNJJJGBCEDG_ = value;
			jNJJJGBCEDGCase_ = ((value != null) ? JNJJJGBCEDGOneofCase.LobbyMarbleInfo : JNJJJGBCEDGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIFJHEPAFOO NIFBKKNFKEG
	{
		get
		{
			if (jNJJJGBCEDGCase_ != JNJJJGBCEDGOneofCase.NIFBKKNFKEG)
			{
				return null;
			}
			return (OIFJHEPAFOO)jNJJJGBCEDG_;
		}
		set
		{
			jNJJJGBCEDG_ = value;
			jNJJJGBCEDGCase_ = ((value != null) ? JNJJJGBCEDGOneofCase.NIFBKKNFKEG : JNJJJGBCEDGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGridFightInfo LobbyGridFightInfo
	{
		get
		{
			if (jNJJJGBCEDGCase_ != JNJJJGBCEDGOneofCase.LobbyGridFightInfo)
			{
				return null;
			}
			return (LobbyGridFightInfo)jNJJJGBCEDG_;
		}
		set
		{
			jNJJJGBCEDG_ = value;
			jNJJJGBCEDGCase_ = ((value != null) ? JNJJJGBCEDGOneofCase.LobbyGridFightInfo : JNJJJGBCEDGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCJAMHEGKGE PCFNJJCOJED
	{
		get
		{
			if (jNJJJGBCEDGCase_ != JNJJJGBCEDGOneofCase.PCFNJJCOJED)
			{
				return null;
			}
			return (GCJAMHEGKGE)jNJJJGBCEDG_;
		}
		set
		{
			jNJJJGBCEDG_ = value;
			jNJJJGBCEDGCase_ = ((value != null) ? JNJJJGBCEDGOneofCase.PCFNJJCOJED : JNJJJGBCEDGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNJJJGBCEDGOneofCase JNJJJGBCEDGCase => jNJJJGBCEDGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo(LobbyGameExtInfo other)
		: this()
	{
		bHILEPGIFNE_ = other.bHILEPGIFNE_.Clone();
		hMPCFJPJDOE_ = other.hMPCFJPJDOE_;
		switch (other.JNJJJGBCEDGCase)
		{
		case JNJJJGBCEDGOneofCase.LobbyMarchInfo:
			LobbyMarchInfo = other.LobbyMarchInfo.Clone();
			break;
		case JNJJJGBCEDGOneofCase.LobbyMarbleInfo:
			LobbyMarbleInfo = other.LobbyMarbleInfo.Clone();
			break;
		case JNJJJGBCEDGOneofCase.NIFBKKNFKEG:
			NIFBKKNFKEG = other.NIFBKKNFKEG.Clone();
			break;
		case JNJJJGBCEDGOneofCase.LobbyGridFightInfo:
			LobbyGridFightInfo = other.LobbyGridFightInfo.Clone();
			break;
		case JNJJJGBCEDGOneofCase.PCFNJJCOJED:
			PCFNJJCOJED = other.PCFNJJCOJED.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo Clone()
	{
		return new LobbyGameExtInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJNJJJGBCEDG()
	{
		jNJJJGBCEDGCase_ = JNJJJGBCEDGOneofCase.None;
		jNJJJGBCEDG_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyGameExtInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyGameExtInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bHILEPGIFNE_.Equals(other.bHILEPGIFNE_))
		{
			return false;
		}
		if (HMPCFJPJDOE != other.HMPCFJPJDOE)
		{
			return false;
		}
		if (!object.Equals(LobbyMarchInfo, other.LobbyMarchInfo))
		{
			return false;
		}
		if (!object.Equals(LobbyMarbleInfo, other.LobbyMarbleInfo))
		{
			return false;
		}
		if (!object.Equals(NIFBKKNFKEG, other.NIFBKKNFKEG))
		{
			return false;
		}
		if (!object.Equals(LobbyGridFightInfo, other.LobbyGridFightInfo))
		{
			return false;
		}
		if (!object.Equals(PCFNJJCOJED, other.PCFNJJCOJED))
		{
			return false;
		}
		if (JNJJJGBCEDGCase != other.JNJJJGBCEDGCase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= bHILEPGIFNE_.GetHashCode();
		if (HMPCFJPJDOE)
		{
			num ^= HMPCFJPJDOE.GetHashCode();
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarchInfo)
		{
			num ^= LobbyMarchInfo.GetHashCode();
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarbleInfo)
		{
			num ^= LobbyMarbleInfo.GetHashCode();
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.NIFBKKNFKEG)
		{
			num ^= NIFBKKNFKEG.GetHashCode();
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyGridFightInfo)
		{
			num ^= LobbyGridFightInfo.GetHashCode();
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.PCFNJJCOJED)
		{
			num ^= PCFNJJCOJED.GetHashCode();
		}
		num ^= (int)jNJJJGBCEDGCase_;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		bHILEPGIFNE_.WriteTo(ref output, _repeated_bHILEPGIFNE_codec);
		if (HMPCFJPJDOE)
		{
			output.WriteRawTag(16);
			output.WriteBool(HMPCFJPJDOE);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarchInfo)
		{
			output.WriteRawTag(202, 62);
			output.WriteMessage(LobbyMarchInfo);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarbleInfo)
		{
			output.WriteRawTag(210, 62);
			output.WriteMessage(LobbyMarbleInfo);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.NIFBKKNFKEG)
		{
			output.WriteRawTag(218, 62);
			output.WriteMessage(NIFBKKNFKEG);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyGridFightInfo)
		{
			output.WriteRawTag(226, 62);
			output.WriteMessage(LobbyGridFightInfo);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.PCFNJJCOJED)
		{
			output.WriteRawTag(234, 62);
			output.WriteMessage(PCFNJJCOJED);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += bHILEPGIFNE_.CalculateSize(_repeated_bHILEPGIFNE_codec);
		if (HMPCFJPJDOE)
		{
			num += 2;
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarchInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LobbyMarchInfo);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarbleInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LobbyMarbleInfo);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.NIFBKKNFKEG)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NIFBKKNFKEG);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyGridFightInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LobbyGridFightInfo);
		}
		if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.PCFNJJCOJED)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PCFNJJCOJED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyGameExtInfo other)
	{
		if (other == null)
		{
			return;
		}
		bHILEPGIFNE_.Add(other.bHILEPGIFNE_);
		if (other.HMPCFJPJDOE)
		{
			HMPCFJPJDOE = other.HMPCFJPJDOE;
		}
		switch (other.JNJJJGBCEDGCase)
		{
		case JNJJJGBCEDGOneofCase.LobbyMarchInfo:
			if (LobbyMarchInfo == null)
			{
				LobbyMarchInfo = new LobbyMarchInfo();
			}
			LobbyMarchInfo.MergeFrom(other.LobbyMarchInfo);
			break;
		case JNJJJGBCEDGOneofCase.LobbyMarbleInfo:
			if (LobbyMarbleInfo == null)
			{
				LobbyMarbleInfo = new LobbyMarbleInfo();
			}
			LobbyMarbleInfo.MergeFrom(other.LobbyMarbleInfo);
			break;
		case JNJJJGBCEDGOneofCase.NIFBKKNFKEG:
			if (NIFBKKNFKEG == null)
			{
				NIFBKKNFKEG = new OIFJHEPAFOO();
			}
			NIFBKKNFKEG.MergeFrom(other.NIFBKKNFKEG);
			break;
		case JNJJJGBCEDGOneofCase.LobbyGridFightInfo:
			if (LobbyGridFightInfo == null)
			{
				LobbyGridFightInfo = new LobbyGridFightInfo();
			}
			LobbyGridFightInfo.MergeFrom(other.LobbyGridFightInfo);
			break;
		case JNJJJGBCEDGOneofCase.PCFNJJCOJED:
			if (PCFNJJCOJED == null)
			{
				PCFNJJCOJED = new GCJAMHEGKGE();
			}
			PCFNJJCOJED.MergeFrom(other.PCFNJJCOJED);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				bHILEPGIFNE_.AddEntriesFrom(ref input, _repeated_bHILEPGIFNE_codec);
				break;
			case 16u:
				HMPCFJPJDOE = input.ReadBool();
				break;
			case 8010u:
			{
				LobbyMarchInfo lobbyMarchInfo = new LobbyMarchInfo();
				if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarchInfo)
				{
					lobbyMarchInfo.MergeFrom(LobbyMarchInfo);
				}
				input.ReadMessage(lobbyMarchInfo);
				LobbyMarchInfo = lobbyMarchInfo;
				break;
			}
			case 8018u:
			{
				LobbyMarbleInfo lobbyMarbleInfo = new LobbyMarbleInfo();
				if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyMarbleInfo)
				{
					lobbyMarbleInfo.MergeFrom(LobbyMarbleInfo);
				}
				input.ReadMessage(lobbyMarbleInfo);
				LobbyMarbleInfo = lobbyMarbleInfo;
				break;
			}
			case 8026u:
			{
				OIFJHEPAFOO oIFJHEPAFOO = new OIFJHEPAFOO();
				if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.NIFBKKNFKEG)
				{
					oIFJHEPAFOO.MergeFrom(NIFBKKNFKEG);
				}
				input.ReadMessage(oIFJHEPAFOO);
				NIFBKKNFKEG = oIFJHEPAFOO;
				break;
			}
			case 8034u:
			{
				LobbyGridFightInfo lobbyGridFightInfo = new LobbyGridFightInfo();
				if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.LobbyGridFightInfo)
				{
					lobbyGridFightInfo.MergeFrom(LobbyGridFightInfo);
				}
				input.ReadMessage(lobbyGridFightInfo);
				LobbyGridFightInfo = lobbyGridFightInfo;
				break;
			}
			case 8042u:
			{
				GCJAMHEGKGE gCJAMHEGKGE = new GCJAMHEGKGE();
				if (jNJJJGBCEDGCase_ == JNJJJGBCEDGOneofCase.PCFNJJCOJED)
				{
					gCJAMHEGKGE.MergeFrom(PCFNJJCOJED);
				}
				input.ReadMessage(gCJAMHEGKGE);
				PCFNJJCOJED = gCJAMHEGKGE;
				break;
			}
			}
		}
	}
}
