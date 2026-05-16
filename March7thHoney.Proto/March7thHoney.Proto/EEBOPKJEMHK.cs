using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EEBOPKJEMHK : IMessage<EEBOPKJEMHK>, IMessage, IEquatable<EEBOPKJEMHK>, IDeepCloneable<EEBOPKJEMHK>, IBufferMessage
{
	private static readonly MessageParser<EEBOPKJEMHK> _parser = new MessageParser<EEBOPKJEMHK>(() => new EEBOPKJEMHK());

	private UnknownFieldSet _unknownFields;

	public const int HCAEJFMKMNDFieldNumber = 7;

	private uint hCAEJFMKMND_;

	public const int StatusFieldNumber = 12;

	private FDMMAAHEFPK status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EEBOPKJEMHK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EEBOPKJEMHKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCAEJFMKMND
	{
		get
		{
			return hCAEJFMKMND_;
		}
		set
		{
			hCAEJFMKMND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDMMAAHEFPK Status
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
	public EEBOPKJEMHK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEBOPKJEMHK(EEBOPKJEMHK other)
		: this()
	{
		hCAEJFMKMND_ = other.hCAEJFMKMND_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEBOPKJEMHK Clone()
	{
		return new EEBOPKJEMHK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EEBOPKJEMHK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EEBOPKJEMHK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCAEJFMKMND != other.HCAEJFMKMND)
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
		if (HCAEJFMKMND != 0)
		{
			num ^= HCAEJFMKMND.GetHashCode();
		}
		if (Status != FDMMAAHEFPK.Oafcmphbkkl)
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
		if (HCAEJFMKMND != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HCAEJFMKMND);
		}
		if (Status != FDMMAAHEFPK.Oafcmphbkkl)
		{
			output.WriteRawTag(96);
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
		if (HCAEJFMKMND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCAEJFMKMND);
		}
		if (Status != FDMMAAHEFPK.Oafcmphbkkl)
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
	public void MergeFrom(EEBOPKJEMHK other)
	{
		if (other != null)
		{
			if (other.HCAEJFMKMND != 0)
			{
				HCAEJFMKMND = other.HCAEJFMKMND;
			}
			if (other.Status != FDMMAAHEFPK.Oafcmphbkkl)
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
			case 56u:
				HCAEJFMKMND = input.ReadUInt32();
				break;
			case 96u:
				Status = (FDMMAAHEFPK)input.ReadEnum();
				break;
			}
		}
	}
}
