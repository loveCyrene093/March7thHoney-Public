using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RougeTournRenameBuildRefCsReq : IMessage<RougeTournRenameBuildRefCsReq>, IMessage, IEquatable<RougeTournRenameBuildRefCsReq>, IDeepCloneable<RougeTournRenameBuildRefCsReq>, IBufferMessage
{
	private static readonly MessageParser<RougeTournRenameBuildRefCsReq> _parser = new MessageParser<RougeTournRenameBuildRefCsReq>(() => new RougeTournRenameBuildRefCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 11;

	private string name_ = "";

	public const int KKGIEENCOICFieldNumber = 12;

	private uint kKGIEENCOIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RougeTournRenameBuildRefCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RougeTournRenameBuildRefCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RougeTournRenameBuildRefCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RougeTournRenameBuildRefCsReq(RougeTournRenameBuildRefCsReq other)
		: this()
	{
		name_ = other.name_;
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RougeTournRenameBuildRefCsReq Clone()
	{
		return new RougeTournRenameBuildRefCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RougeTournRenameBuildRefCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RougeTournRenameBuildRefCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Name);
		}
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KKGIEENCOIC);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RougeTournRenameBuildRefCsReq other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.KKGIEENCOIC != 0)
			{
				KKGIEENCOIC = other.KKGIEENCOIC;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 90u:
				Name = input.ReadString();
				break;
			case 96u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			}
		}
	}
}
