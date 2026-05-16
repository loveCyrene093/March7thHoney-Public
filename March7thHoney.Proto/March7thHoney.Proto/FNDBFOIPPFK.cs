using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FNDBFOIPPFK : IMessage<FNDBFOIPPFK>, IMessage, IEquatable<FNDBFOIPPFK>, IDeepCloneable<FNDBFOIPPFK>, IBufferMessage
{
	private static readonly MessageParser<FNDBFOIPPFK> _parser = new MessageParser<FNDBFOIPPFK>(() => new FNDBFOIPPFK());

	private UnknownFieldSet _unknownFields;

	public const int DBFNJOPIAFEFieldNumber = 15;

	private uint dBFNJOPIAFE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FNDBFOIPPFK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FNDBFOIPPFKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DBFNJOPIAFE
	{
		get
		{
			return dBFNJOPIAFE_;
		}
		set
		{
			dBFNJOPIAFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNDBFOIPPFK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNDBFOIPPFK(FNDBFOIPPFK other)
		: this()
	{
		dBFNJOPIAFE_ = other.dBFNJOPIAFE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNDBFOIPPFK Clone()
	{
		return new FNDBFOIPPFK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FNDBFOIPPFK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FNDBFOIPPFK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DBFNJOPIAFE != other.DBFNJOPIAFE)
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
		if (DBFNJOPIAFE != 0)
		{
			num ^= DBFNJOPIAFE.GetHashCode();
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
		if (DBFNJOPIAFE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DBFNJOPIAFE);
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
		if (DBFNJOPIAFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DBFNJOPIAFE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FNDBFOIPPFK other)
	{
		if (other != null)
		{
			if (other.DBFNJOPIAFE != 0)
			{
				DBFNJOPIAFE = other.DBFNJOPIAFE;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DBFNJOPIAFE = input.ReadUInt32();
			}
		}
	}
}
