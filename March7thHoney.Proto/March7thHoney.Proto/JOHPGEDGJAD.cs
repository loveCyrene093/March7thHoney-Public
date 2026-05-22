using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JOHPGEDGJAD : IMessage<JOHPGEDGJAD>, IMessage, IEquatable<JOHPGEDGJAD>, IDeepCloneable<JOHPGEDGJAD>, IBufferMessage
{
	private static readonly MessageParser<JOHPGEDGJAD> _parser = new MessageParser<JOHPGEDGJAD>(() => new JOHPGEDGJAD());

	private UnknownFieldSet _unknownFields;

	public const int GNBLOHMPACLFieldNumber = 3;

	private uint gNBLOHMPACL_;

	public const int ProgressFieldNumber = 11;

	private uint progress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JOHPGEDGJAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JOHPGEDGJADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GNBLOHMPACL
	{
		get
		{
			return gNBLOHMPACL_;
		}
		set
		{
			gNBLOHMPACL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOHPGEDGJAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOHPGEDGJAD(JOHPGEDGJAD other)
		: this()
	{
		gNBLOHMPACL_ = other.gNBLOHMPACL_;
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOHPGEDGJAD Clone()
	{
		return new JOHPGEDGJAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JOHPGEDGJAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JOHPGEDGJAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GNBLOHMPACL != other.GNBLOHMPACL)
		{
			return false;
		}
		if (Progress != other.Progress)
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
		if (GNBLOHMPACL != 0)
		{
			num ^= GNBLOHMPACL.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
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
		if (GNBLOHMPACL != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GNBLOHMPACL);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Progress);
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
		if (GNBLOHMPACL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GNBLOHMPACL);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JOHPGEDGJAD other)
	{
		if (other != null)
		{
			if (other.GNBLOHMPACL != 0)
			{
				GNBLOHMPACL = other.GNBLOHMPACL;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
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
				GNBLOHMPACL = input.ReadUInt32();
				break;
			case 88u:
				Progress = input.ReadUInt32();
				break;
			}
		}
	}
}
