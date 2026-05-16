using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournSaveBuildRefCsReq : IMessage<RogueTournSaveBuildRefCsReq>, IMessage, IEquatable<RogueTournSaveBuildRefCsReq>, IDeepCloneable<RogueTournSaveBuildRefCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournSaveBuildRefCsReq> _parser = new MessageParser<RogueTournSaveBuildRefCsReq>(() => new RogueTournSaveBuildRefCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KKGIEENCOICFieldNumber = 9;

	private uint kKGIEENCOIC_;

	public const int NameFieldNumber = 13;

	private string name_ = "";

	public const int EOGACILLEBOFieldNumber = 14;

	private AKCFLPEANJB eOGACILLEBO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournSaveBuildRefCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournSaveBuildRefCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKGIEENCOIC
	{
		get
		{
			return kKGIEENCOIC_;
		}
		set
		{
			kKGIEENCOIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKCFLPEANJB EOGACILLEBO
	{
		get
		{
			return eOGACILLEBO_;
		}
		set
		{
			eOGACILLEBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournSaveBuildRefCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournSaveBuildRefCsReq(RogueTournSaveBuildRefCsReq other)
		: this()
	{
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		name_ = other.name_;
		eOGACILLEBO_ = ((other.eOGACILLEBO_ != null) ? other.eOGACILLEBO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournSaveBuildRefCsReq Clone()
	{
		return new RogueTournSaveBuildRefCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournSaveBuildRefCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournSaveBuildRefCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!object.Equals(EOGACILLEBO, other.EOGACILLEBO))
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
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (eOGACILLEBO_ != null)
		{
			num ^= EOGACILLEBO.GetHashCode();
		}
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
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(Name);
		}
		if (eOGACILLEBO_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EOGACILLEBO);
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
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (eOGACILLEBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOGACILLEBO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournSaveBuildRefCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KKGIEENCOIC != 0)
		{
			KKGIEENCOIC = other.KKGIEENCOIC;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.eOGACILLEBO_ != null)
		{
			if (eOGACILLEBO_ == null)
			{
				EOGACILLEBO = new AKCFLPEANJB();
			}
			EOGACILLEBO.MergeFrom(other.EOGACILLEBO);
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
			case 72u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 106u:
				Name = input.ReadString();
				break;
			case 114u:
				if (eOGACILLEBO_ == null)
				{
					EOGACILLEBO = new AKCFLPEANJB();
				}
				input.ReadMessage(EOGACILLEBO);
				break;
			}
		}
	}
}
