using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MMPOOBGAEKE : IMessage<MMPOOBGAEKE>, IMessage, IEquatable<MMPOOBGAEKE>, IDeepCloneable<MMPOOBGAEKE>, IBufferMessage
{
	private static readonly MessageParser<MMPOOBGAEKE> _parser = new MessageParser<MMPOOBGAEKE>(() => new MMPOOBGAEKE());

	private UnknownFieldSet _unknownFields;

	public const int MKBIOANPMKEFieldNumber = 8;

	private uint mKBIOANPMKE_;

	public const int StatusFieldNumber = 11;

	private DICJKJNENCP status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MMPOOBGAEKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MMPOOBGAEKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKBIOANPMKE
	{
		get
		{
			return mKBIOANPMKE_;
		}
		set
		{
			mKBIOANPMKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DICJKJNENCP Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMPOOBGAEKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMPOOBGAEKE(MMPOOBGAEKE other)
		: this()
	{
		mKBIOANPMKE_ = other.mKBIOANPMKE_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMPOOBGAEKE Clone()
	{
		return new MMPOOBGAEKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MMPOOBGAEKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MMPOOBGAEKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MKBIOANPMKE != other.MKBIOANPMKE)
		{
			return false;
		}
		if (Status != other.Status)
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
		if (MKBIOANPMKE != 0)
		{
			num ^= MKBIOANPMKE.GetHashCode();
		}
		if (Status != DICJKJNENCP.Geboholbjph)
		{
			num ^= Status.GetHashCode();
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
		if (MKBIOANPMKE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MKBIOANPMKE);
		}
		if (Status != DICJKJNENCP.Geboholbjph)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Status);
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
		if (MKBIOANPMKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKBIOANPMKE);
		}
		if (Status != DICJKJNENCP.Geboholbjph)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MMPOOBGAEKE other)
	{
		if (other != null)
		{
			if (other.MKBIOANPMKE != 0)
			{
				MKBIOANPMKE = other.MKBIOANPMKE;
			}
			if (other.Status != DICJKJNENCP.Geboholbjph)
			{
				Status = other.Status;
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
			case 64u:
				MKBIOANPMKE = input.ReadUInt32();
				break;
			case 88u:
				Status = (DICJKJNENCP)input.ReadEnum();
				break;
			}
		}
	}
}
