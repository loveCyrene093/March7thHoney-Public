using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FiveDimMoneyChangeScNotify : IMessage<FiveDimMoneyChangeScNotify>, IMessage, IEquatable<FiveDimMoneyChangeScNotify>, IDeepCloneable<FiveDimMoneyChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<FiveDimMoneyChangeScNotify> _parser = new MessageParser<FiveDimMoneyChangeScNotify>(() => new FiveDimMoneyChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int NDKMOINLOOEFieldNumber = 5;

	private uint nDKMOINLOOE_;

	public const int JKLDOFBHABMFieldNumber = 14;

	private uint jKLDOFBHABM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FiveDimMoneyChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FiveDimMoneyChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FiveDimMoneyChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimMoneyChangeScNotify(FiveDimMoneyChangeScNotify other)
		: this()
	{
		nDKMOINLOOE_ = other.nDKMOINLOOE_;
		jKLDOFBHABM_ = other.jKLDOFBHABM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FiveDimMoneyChangeScNotify Clone()
	{
		return new FiveDimMoneyChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FiveDimMoneyChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FiveDimMoneyChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NDKMOINLOOE != other.NDKMOINLOOE)
		{
			return false;
		}
		if (JKLDOFBHABM != other.JKLDOFBHABM)
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
		if (NDKMOINLOOE != 0)
		{
			num ^= NDKMOINLOOE.GetHashCode();
		}
		if (JKLDOFBHABM != 0)
		{
			num ^= JKLDOFBHABM.GetHashCode();
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
		if (NDKMOINLOOE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NDKMOINLOOE);
		}
		if (JKLDOFBHABM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JKLDOFBHABM);
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
		if (NDKMOINLOOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDKMOINLOOE);
		}
		if (JKLDOFBHABM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKLDOFBHABM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FiveDimMoneyChangeScNotify other)
	{
		if (other != null)
		{
			if (other.NDKMOINLOOE != 0)
			{
				NDKMOINLOOE = other.NDKMOINLOOE;
			}
			if (other.JKLDOFBHABM != 0)
			{
				JKLDOFBHABM = other.JKLDOFBHABM;
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
			case 40u:
				NDKMOINLOOE = input.ReadUInt32();
				break;
			case 112u:
				JKLDOFBHABM = input.ReadUInt32();
				break;
			}
		}
	}
}
