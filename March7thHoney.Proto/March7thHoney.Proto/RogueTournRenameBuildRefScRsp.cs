using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournRenameBuildRefScRsp : IMessage<RogueTournRenameBuildRefScRsp>, IMessage, IEquatable<RogueTournRenameBuildRefScRsp>, IDeepCloneable<RogueTournRenameBuildRefScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournRenameBuildRefScRsp> _parser = new MessageParser<RogueTournRenameBuildRefScRsp>(() => new RogueTournRenameBuildRefScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KKGIEENCOICFieldNumber = 3;

	private uint kKGIEENCOIC_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int NameFieldNumber = 11;

	private string name_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournRenameBuildRefScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournRenameBuildRefScRspReflection.Descriptor.MessageTypes[0];

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
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
	public RogueTournRenameBuildRefScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournRenameBuildRefScRsp(RogueTournRenameBuildRefScRsp other)
		: this()
	{
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		retcode_ = other.retcode_;
		name_ = other.name_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournRenameBuildRefScRsp Clone()
	{
		return new RogueTournRenameBuildRefScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournRenameBuildRefScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournRenameBuildRefScRsp other)
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
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Name != other.Name)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Name);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournRenameBuildRefScRsp other)
	{
		if (other != null)
		{
			if (other.KKGIEENCOIC != 0)
			{
				KKGIEENCOIC = other.KKGIEENCOIC;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
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
			case 24u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
