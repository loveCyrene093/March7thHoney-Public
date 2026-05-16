using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CPPAAIIHAGI : IMessage<CPPAAIIHAGI>, IMessage, IEquatable<CPPAAIIHAGI>, IDeepCloneable<CPPAAIIHAGI>, IBufferMessage
{
	private static readonly MessageParser<CPPAAIIHAGI> _parser = new MessageParser<CPPAAIIHAGI>(() => new CPPAAIIHAGI());

	private UnknownFieldSet _unknownFields;

	public const int LDLOHFLEOMGFieldNumber = 1;

	private uint lDLOHFLEOMG_;

	public const int DDPKJKHEDLHFieldNumber = 4;

	private static readonly FieldCodec<NAKIGLPGKBA> _repeated_dDPKJKHEDLH_codec = FieldCodec.ForMessage(34u, NAKIGLPGKBA.Parser);

	private readonly RepeatedField<NAKIGLPGKBA> dDPKJKHEDLH_ = new RepeatedField<NAKIGLPGKBA>();

	public const int GJGKIANENIPFieldNumber = 6;

	private uint gJGKIANENIP_;

	public const int MOEFPFOJEDIFieldNumber = 8;

	private uint mOEFPFOJEDI_;

	public const int JNBGEFJPKCCFieldNumber = 11;

	private uint jNBGEFJPKCC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CPPAAIIHAGI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CPPAAIIHAGIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDLOHFLEOMG
	{
		get
		{
			return lDLOHFLEOMG_;
		}
		set
		{
			lDLOHFLEOMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NAKIGLPGKBA> DDPKJKHEDLH => dDPKJKHEDLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJGKIANENIP
	{
		get
		{
			return gJGKIANENIP_;
		}
		set
		{
			gJGKIANENIP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOEFPFOJEDI
	{
		get
		{
			return mOEFPFOJEDI_;
		}
		set
		{
			mOEFPFOJEDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNBGEFJPKCC
	{
		get
		{
			return jNBGEFJPKCC_;
		}
		set
		{
			jNBGEFJPKCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPPAAIIHAGI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPPAAIIHAGI(CPPAAIIHAGI other)
		: this()
	{
		lDLOHFLEOMG_ = other.lDLOHFLEOMG_;
		dDPKJKHEDLH_ = other.dDPKJKHEDLH_.Clone();
		gJGKIANENIP_ = other.gJGKIANENIP_;
		mOEFPFOJEDI_ = other.mOEFPFOJEDI_;
		jNBGEFJPKCC_ = other.jNBGEFJPKCC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPPAAIIHAGI Clone()
	{
		return new CPPAAIIHAGI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CPPAAIIHAGI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CPPAAIIHAGI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LDLOHFLEOMG != other.LDLOHFLEOMG)
		{
			return false;
		}
		if (!dDPKJKHEDLH_.Equals(other.dDPKJKHEDLH_))
		{
			return false;
		}
		if (GJGKIANENIP != other.GJGKIANENIP)
		{
			return false;
		}
		if (MOEFPFOJEDI != other.MOEFPFOJEDI)
		{
			return false;
		}
		if (JNBGEFJPKCC != other.JNBGEFJPKCC)
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
		if (LDLOHFLEOMG != 0)
		{
			num ^= LDLOHFLEOMG.GetHashCode();
		}
		num ^= dDPKJKHEDLH_.GetHashCode();
		if (GJGKIANENIP != 0)
		{
			num ^= GJGKIANENIP.GetHashCode();
		}
		if (MOEFPFOJEDI != 0)
		{
			num ^= MOEFPFOJEDI.GetHashCode();
		}
		if (JNBGEFJPKCC != 0)
		{
			num ^= JNBGEFJPKCC.GetHashCode();
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
		if (LDLOHFLEOMG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LDLOHFLEOMG);
		}
		dDPKJKHEDLH_.WriteTo(ref output, _repeated_dDPKJKHEDLH_codec);
		if (GJGKIANENIP != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GJGKIANENIP);
		}
		if (MOEFPFOJEDI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MOEFPFOJEDI);
		}
		if (JNBGEFJPKCC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JNBGEFJPKCC);
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
		if (LDLOHFLEOMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDLOHFLEOMG);
		}
		num += dDPKJKHEDLH_.CalculateSize(_repeated_dDPKJKHEDLH_codec);
		if (GJGKIANENIP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJGKIANENIP);
		}
		if (MOEFPFOJEDI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOEFPFOJEDI);
		}
		if (JNBGEFJPKCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNBGEFJPKCC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CPPAAIIHAGI other)
	{
		if (other != null)
		{
			if (other.LDLOHFLEOMG != 0)
			{
				LDLOHFLEOMG = other.LDLOHFLEOMG;
			}
			dDPKJKHEDLH_.Add(other.dDPKJKHEDLH_);
			if (other.GJGKIANENIP != 0)
			{
				GJGKIANENIP = other.GJGKIANENIP;
			}
			if (other.MOEFPFOJEDI != 0)
			{
				MOEFPFOJEDI = other.MOEFPFOJEDI;
			}
			if (other.JNBGEFJPKCC != 0)
			{
				JNBGEFJPKCC = other.JNBGEFJPKCC;
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
				LDLOHFLEOMG = input.ReadUInt32();
				break;
			case 34u:
				dDPKJKHEDLH_.AddEntriesFrom(ref input, _repeated_dDPKJKHEDLH_codec);
				break;
			case 48u:
				GJGKIANENIP = input.ReadUInt32();
				break;
			case 64u:
				MOEFPFOJEDI = input.ReadUInt32();
				break;
			case 88u:
				JNBGEFJPKCC = input.ReadUInt32();
				break;
			}
		}
	}
}
