using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APEJMBBBLGF : IMessage<APEJMBBBLGF>, IMessage, IEquatable<APEJMBBBLGF>, IDeepCloneable<APEJMBBBLGF>, IBufferMessage
{
	private static readonly MessageParser<APEJMBBBLGF> _parser = new MessageParser<APEJMBBBLGF>(() => new APEJMBBBLGF());

	private UnknownFieldSet _unknownFields;

	public const int JKPGACLKEECFieldNumber = 13;

	private uint jKPGACLKEEC_;

	public const int KGNDHGKKOMMFieldNumber = 14;

	private BJLIAEJNDJK kGNDHGKKOMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APEJMBBBLGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APEJMBBBLGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJLIAEJNDJK KGNDHGKKOMM
	{
		get
		{
			return kGNDHGKKOMM_;
		}
		set
		{
			kGNDHGKKOMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APEJMBBBLGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APEJMBBBLGF(APEJMBBBLGF other)
		: this()
	{
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		kGNDHGKKOMM_ = ((other.kGNDHGKKOMM_ != null) ? other.kGNDHGKKOMM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APEJMBBBLGF Clone()
	{
		return new APEJMBBBLGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APEJMBBBLGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APEJMBBBLGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (!object.Equals(KGNDHGKKOMM, other.KGNDHGKKOMM))
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
		if (JKPGACLKEEC != 0)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (kGNDHGKKOMM_ != null)
		{
			num ^= KGNDHGKKOMM.GetHashCode();
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
		if (JKPGACLKEEC != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JKPGACLKEEC);
		}
		if (kGNDHGKKOMM_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(KGNDHGKKOMM);
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
		if (JKPGACLKEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKPGACLKEEC);
		}
		if (kGNDHGKKOMM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGNDHGKKOMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APEJMBBBLGF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JKPGACLKEEC != 0)
		{
			JKPGACLKEEC = other.JKPGACLKEEC;
		}
		if (other.kGNDHGKKOMM_ != null)
		{
			if (kGNDHGKKOMM_ == null)
			{
				KGNDHGKKOMM = new BJLIAEJNDJK();
			}
			KGNDHGKKOMM.MergeFrom(other.KGNDHGKKOMM);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 104u:
				JKPGACLKEEC = input.ReadUInt32();
				break;
			case 114u:
				if (kGNDHGKKOMM_ == null)
				{
					KGNDHGKKOMM = new BJLIAEJNDJK();
				}
				input.ReadMessage(KGNDHGKKOMM);
				break;
			}
		}
	}
}
