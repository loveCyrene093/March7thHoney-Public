using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBKLHLJGNGP : IMessage<NBKLHLJGNGP>, IMessage, IEquatable<NBKLHLJGNGP>, IDeepCloneable<NBKLHLJGNGP>, IBufferMessage
{
	private static readonly MessageParser<NBKLHLJGNGP> _parser = new MessageParser<NBKLHLJGNGP>(() => new NBKLHLJGNGP());

	private UnknownFieldSet _unknownFields;

	public const int MMOOIAMFJEKFieldNumber = 6;

	private uint mMOOIAMFJEK_;

	public const int DMEKIFJDKFLFieldNumber = 15;

	private uint dMEKIFJDKFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBKLHLJGNGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBKLHLJGNGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMOOIAMFJEK
	{
		get
		{
			return mMOOIAMFJEK_;
		}
		set
		{
			mMOOIAMFJEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMEKIFJDKFL
	{
		get
		{
			return dMEKIFJDKFL_;
		}
		set
		{
			dMEKIFJDKFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKLHLJGNGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKLHLJGNGP(NBKLHLJGNGP other)
		: this()
	{
		mMOOIAMFJEK_ = other.mMOOIAMFJEK_;
		dMEKIFJDKFL_ = other.dMEKIFJDKFL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKLHLJGNGP Clone()
	{
		return new NBKLHLJGNGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBKLHLJGNGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBKLHLJGNGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MMOOIAMFJEK != other.MMOOIAMFJEK)
		{
			return false;
		}
		if (DMEKIFJDKFL != other.DMEKIFJDKFL)
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
		if (MMOOIAMFJEK != 0)
		{
			num ^= MMOOIAMFJEK.GetHashCode();
		}
		if (DMEKIFJDKFL != 0)
		{
			num ^= DMEKIFJDKFL.GetHashCode();
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
		if (MMOOIAMFJEK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MMOOIAMFJEK);
		}
		if (DMEKIFJDKFL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DMEKIFJDKFL);
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
		if (MMOOIAMFJEK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMOOIAMFJEK);
		}
		if (DMEKIFJDKFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMEKIFJDKFL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBKLHLJGNGP other)
	{
		if (other != null)
		{
			if (other.MMOOIAMFJEK != 0)
			{
				MMOOIAMFJEK = other.MMOOIAMFJEK;
			}
			if (other.DMEKIFJDKFL != 0)
			{
				DMEKIFJDKFL = other.DMEKIFJDKFL;
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
			case 48u:
				MMOOIAMFJEK = input.ReadUInt32();
				break;
			case 120u:
				DMEKIFJDKFL = input.ReadUInt32();
				break;
			}
		}
	}
}
