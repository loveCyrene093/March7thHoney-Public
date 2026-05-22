using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EGNLCNJDNCK : IMessage<EGNLCNJDNCK>, IMessage, IEquatable<EGNLCNJDNCK>, IDeepCloneable<EGNLCNJDNCK>, IBufferMessage
{
	private static readonly MessageParser<EGNLCNJDNCK> _parser = new MessageParser<EGNLCNJDNCK>(() => new EGNLCNJDNCK());

	private UnknownFieldSet _unknownFields;

	public const int KACDGAJHNBIFieldNumber = 1;

	private uint kACDGAJHNBI_;

	public const int DBEJDKHLHJEFieldNumber = 10;

	private uint dBEJDKHLHJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EGNLCNJDNCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EGNLCNJDNCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KACDGAJHNBI
	{
		get
		{
			return kACDGAJHNBI_;
		}
		set
		{
			kACDGAJHNBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBEJDKHLHJE
	{
		get
		{
			return dBEJDKHLHJE_;
		}
		set
		{
			dBEJDKHLHJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGNLCNJDNCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGNLCNJDNCK(EGNLCNJDNCK other)
		: this()
	{
		kACDGAJHNBI_ = other.kACDGAJHNBI_;
		dBEJDKHLHJE_ = other.dBEJDKHLHJE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGNLCNJDNCK Clone()
	{
		return new EGNLCNJDNCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EGNLCNJDNCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EGNLCNJDNCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KACDGAJHNBI != other.KACDGAJHNBI)
		{
			return false;
		}
		if (DBEJDKHLHJE != other.DBEJDKHLHJE)
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
		if (KACDGAJHNBI != 0)
		{
			num ^= KACDGAJHNBI.GetHashCode();
		}
		if (DBEJDKHLHJE != 0)
		{
			num ^= DBEJDKHLHJE.GetHashCode();
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
		if (KACDGAJHNBI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KACDGAJHNBI);
		}
		if (DBEJDKHLHJE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DBEJDKHLHJE);
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
		if (KACDGAJHNBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KACDGAJHNBI);
		}
		if (DBEJDKHLHJE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBEJDKHLHJE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EGNLCNJDNCK other)
	{
		if (other != null)
		{
			if (other.KACDGAJHNBI != 0)
			{
				KACDGAJHNBI = other.KACDGAJHNBI;
			}
			if (other.DBEJDKHLHJE != 0)
			{
				DBEJDKHLHJE = other.DBEJDKHLHJE;
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
				KACDGAJHNBI = input.ReadUInt32();
				break;
			case 80u:
				DBEJDKHLHJE = input.ReadUInt32();
				break;
			}
		}
	}
}
