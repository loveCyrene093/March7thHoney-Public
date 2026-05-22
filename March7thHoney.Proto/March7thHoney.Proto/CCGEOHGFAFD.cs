using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCGEOHGFAFD : IMessage<CCGEOHGFAFD>, IMessage, IEquatable<CCGEOHGFAFD>, IDeepCloneable<CCGEOHGFAFD>, IBufferMessage
{
	private static readonly MessageParser<CCGEOHGFAFD> _parser = new MessageParser<CCGEOHGFAFD>(() => new CCGEOHGFAFD());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 1;

	private uint uniqueId_;

	public const int JCMFPHMFAONFieldNumber = 2;

	private uint jCMFPHMFAON_;

	public const int PosFieldNumber = 3;

	private uint pos_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCGEOHGFAFD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCGEOHGFAFDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCMFPHMFAON
	{
		get
		{
			return jCMFPHMFAON_;
		}
		set
		{
			jCMFPHMFAON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGEOHGFAFD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGEOHGFAFD(CCGEOHGFAFD other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		jCMFPHMFAON_ = other.jCMFPHMFAON_;
		pos_ = other.pos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCGEOHGFAFD Clone()
	{
		return new CCGEOHGFAFD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCGEOHGFAFD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCGEOHGFAFD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (JCMFPHMFAON != other.JCMFPHMFAON)
		{
			return false;
		}
		if (Pos != other.Pos)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (JCMFPHMFAON != 0)
		{
			num ^= JCMFPHMFAON.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(UniqueId);
		}
		if (JCMFPHMFAON != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JCMFPHMFAON);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Pos);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (JCMFPHMFAON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCMFPHMFAON);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCGEOHGFAFD other)
	{
		if (other != null)
		{
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.JCMFPHMFAON != 0)
			{
				JCMFPHMFAON = other.JCMFPHMFAON;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
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
			case 8u:
				UniqueId = input.ReadUInt32();
				break;
			case 16u:
				JCMFPHMFAON = input.ReadUInt32();
				break;
			case 24u:
				Pos = input.ReadUInt32();
				break;
			}
		}
	}
}
