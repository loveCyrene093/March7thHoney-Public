using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFiveDimMoneyDataScRsp : IMessage<GetFiveDimMoneyDataScRsp>, IMessage, IEquatable<GetFiveDimMoneyDataScRsp>, IDeepCloneable<GetFiveDimMoneyDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFiveDimMoneyDataScRsp> _parser = new MessageParser<GetFiveDimMoneyDataScRsp>(() => new GetFiveDimMoneyDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JKLDOFBHABMFieldNumber = 2;

	private uint jKLDOFBHABM_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int NDKMOINLOOEFieldNumber = 12;

	private uint nDKMOINLOOE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFiveDimMoneyDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFiveDimMoneyDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKLDOFBHABM
	{
		get
		{
			return jKLDOFBHABM_;
		}
		set
		{
			jKLDOFBHABM_ = value;
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
	public uint NDKMOINLOOE
	{
		get
		{
			return nDKMOINLOOE_;
		}
		set
		{
			nDKMOINLOOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMoneyDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMoneyDataScRsp(GetFiveDimMoneyDataScRsp other)
		: this()
	{
		jKLDOFBHABM_ = other.jKLDOFBHABM_;
		retcode_ = other.retcode_;
		nDKMOINLOOE_ = other.nDKMOINLOOE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFiveDimMoneyDataScRsp Clone()
	{
		return new GetFiveDimMoneyDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFiveDimMoneyDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFiveDimMoneyDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKLDOFBHABM != other.JKLDOFBHABM)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (NDKMOINLOOE != other.NDKMOINLOOE)
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
		if (JKLDOFBHABM != 0)
		{
			num ^= JKLDOFBHABM.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (NDKMOINLOOE != 0)
		{
			num ^= NDKMOINLOOE.GetHashCode();
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
		if (JKLDOFBHABM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JKLDOFBHABM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (NDKMOINLOOE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NDKMOINLOOE);
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
		if (JKLDOFBHABM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKLDOFBHABM);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (NDKMOINLOOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDKMOINLOOE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFiveDimMoneyDataScRsp other)
	{
		if (other != null)
		{
			if (other.JKLDOFBHABM != 0)
			{
				JKLDOFBHABM = other.JKLDOFBHABM;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.NDKMOINLOOE != 0)
			{
				NDKMOINLOOE = other.NDKMOINLOOE;
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
			case 16u:
				JKLDOFBHABM = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				NDKMOINLOOE = input.ReadUInt32();
				break;
			}
		}
	}
}
