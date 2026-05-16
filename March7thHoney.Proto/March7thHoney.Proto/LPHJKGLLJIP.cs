using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LPHJKGLLJIP : IMessage<LPHJKGLLJIP>, IMessage, IEquatable<LPHJKGLLJIP>, IDeepCloneable<LPHJKGLLJIP>, IBufferMessage
{
	private static readonly MessageParser<LPHJKGLLJIP> _parser = new MessageParser<LPHJKGLLJIP>(() => new LPHJKGLLJIP());

	private UnknownFieldSet _unknownFields;

	public const int EGLCKGKECAJFieldNumber = 4;

	private GCHPNHBDCDO eGLCKGKECAJ_;

	public const int PMCBBMKMHNIFieldNumber = 6;

	private static readonly FieldCodec<GPFMEDLLKGH> _repeated_pMCBBMKMHNI_codec = FieldCodec.ForMessage(50u, GPFMEDLLKGH.Parser);

	private readonly RepeatedField<GPFMEDLLKGH> pMCBBMKMHNI_ = new RepeatedField<GPFMEDLLKGH>();

	public const int ItemValueFieldNumber = 7;

	private uint itemValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LPHJKGLLJIP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LPHJKGLLJIPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCHPNHBDCDO EGLCKGKECAJ
	{
		get
		{
			return eGLCKGKECAJ_;
		}
		set
		{
			eGLCKGKECAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GPFMEDLLKGH> PMCBBMKMHNI => pMCBBMKMHNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LPHJKGLLJIP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LPHJKGLLJIP(LPHJKGLLJIP other)
		: this()
	{
		eGLCKGKECAJ_ = other.eGLCKGKECAJ_;
		pMCBBMKMHNI_ = other.pMCBBMKMHNI_.Clone();
		itemValue_ = other.itemValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LPHJKGLLJIP Clone()
	{
		return new LPHJKGLLJIP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LPHJKGLLJIP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LPHJKGLLJIP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EGLCKGKECAJ != other.EGLCKGKECAJ)
		{
			return false;
		}
		if (!pMCBBMKMHNI_.Equals(other.pMCBBMKMHNI_))
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
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
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num ^= EGLCKGKECAJ.GetHashCode();
		}
		num ^= pMCBBMKMHNI_.GetHashCode();
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
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
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)EGLCKGKECAJ);
		}
		pMCBBMKMHNI_.WriteTo(ref output, _repeated_pMCBBMKMHNI_codec);
		if (ItemValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ItemValue);
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
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EGLCKGKECAJ);
		}
		num += pMCBBMKMHNI_.CalculateSize(_repeated_pMCBBMKMHNI_codec);
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LPHJKGLLJIP other)
	{
		if (other != null)
		{
			if (other.EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
			{
				EGLCKGKECAJ = other.EGLCKGKECAJ;
			}
			pMCBBMKMHNI_.Add(other.pMCBBMKMHNI_);
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
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
			case 32u:
				EGLCKGKECAJ = (GCHPNHBDCDO)input.ReadEnum();
				break;
			case 50u:
				pMCBBMKMHNI_.AddEntriesFrom(ref input, _repeated_pMCBBMKMHNI_codec);
				break;
			case 56u:
				ItemValue = input.ReadUInt32();
				break;
			}
		}
	}
}
