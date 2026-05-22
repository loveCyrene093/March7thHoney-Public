using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BIBLMLDGCOB : IMessage<BIBLMLDGCOB>, IMessage, IEquatable<BIBLMLDGCOB>, IDeepCloneable<BIBLMLDGCOB>, IBufferMessage
{
	private static readonly MessageParser<BIBLMLDGCOB> _parser = new MessageParser<BIBLMLDGCOB>(() => new BIBLMLDGCOB());

	private UnknownFieldSet _unknownFields;

	public const int KDHLCEPPCCJFieldNumber = 2;

	private uint kDHLCEPPCCJ_;

	public const int UidFieldNumber = 4;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BIBLMLDGCOB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BIBLMLDGCOBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KDHLCEPPCCJ
	{
		get
		{
			return kDHLCEPPCCJ_;
		}
		set
		{
			kDHLCEPPCCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBLMLDGCOB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBLMLDGCOB(BIBLMLDGCOB other)
		: this()
	{
		kDHLCEPPCCJ_ = other.kDHLCEPPCCJ_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIBLMLDGCOB Clone()
	{
		return new BIBLMLDGCOB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BIBLMLDGCOB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BIBLMLDGCOB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KDHLCEPPCCJ != other.KDHLCEPPCCJ)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (KDHLCEPPCCJ != 0)
		{
			num ^= KDHLCEPPCCJ.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (KDHLCEPPCCJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KDHLCEPPCCJ);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Uid);
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
		if (KDHLCEPPCCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KDHLCEPPCCJ);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BIBLMLDGCOB other)
	{
		if (other != null)
		{
			if (other.KDHLCEPPCCJ != 0)
			{
				KDHLCEPPCCJ = other.KDHLCEPPCCJ;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
				KDHLCEPPCCJ = input.ReadUInt32();
				break;
			case 32u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
