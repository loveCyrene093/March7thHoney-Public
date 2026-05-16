using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFiveDimMoneyScRsp : IMessage<GetFiveDimMoneyScRsp>, IMessage, IEquatable<GetFiveDimMoneyScRsp>, IDeepCloneable<GetFiveDimMoneyScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFiveDimMoneyScRsp> _parser = new MessageParser<GetFiveDimMoneyScRsp>(() => new GetFiveDimMoneyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int HFMLMJALLPCFieldNumber = 11;

	private uint hFMLMJALLPC_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int HLLKKGIFIPCFieldNumber = 14;

	private uint hLLKKGIFIPC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFiveDimMoneyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFiveDimMoneyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFMLMJALLPC
	{
		get
		{
			return hFMLMJALLPC_;
		}
		set
		{
			hFMLMJALLPC_ = value;
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
	public uint HLLKKGIFIPC
	{
		get
		{
			return hLLKKGIFIPC_;
		}
		set
		{
			hLLKKGIFIPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMoneyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMoneyScRsp(GetFiveDimMoneyScRsp other)
		: this()
	{
		hFMLMJALLPC_ = other.hFMLMJALLPC_;
		retcode_ = other.retcode_;
		hLLKKGIFIPC_ = other.hLLKKGIFIPC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMoneyScRsp Clone()
	{
		return new GetFiveDimMoneyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFiveDimMoneyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFiveDimMoneyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HFMLMJALLPC != other.HFMLMJALLPC)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HLLKKGIFIPC != other.HLLKKGIFIPC)
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
		if (HFMLMJALLPC != 0)
		{
			num ^= HFMLMJALLPC.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HLLKKGIFIPC != 0)
		{
			num ^= HLLKKGIFIPC.GetHashCode();
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
		if (HFMLMJALLPC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HFMLMJALLPC);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (HLLKKGIFIPC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HLLKKGIFIPC);
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
		if (HFMLMJALLPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFMLMJALLPC);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HLLKKGIFIPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HLLKKGIFIPC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFiveDimMoneyScRsp other)
	{
		if (other != null)
		{
			if (other.HFMLMJALLPC != 0)
			{
				HFMLMJALLPC = other.HFMLMJALLPC;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.HLLKKGIFIPC != 0)
			{
				HLLKKGIFIPC = other.HLLKKGIFIPC;
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
			case 88u:
				HFMLMJALLPC = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				HLLKKGIFIPC = input.ReadUInt32();
				break;
			}
		}
	}
}
