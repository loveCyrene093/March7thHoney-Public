using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DoGachaScRsp2 : IMessage<DoGachaScRsp2>, IMessage, IEquatable<DoGachaScRsp2>, IDeepCloneable<DoGachaScRsp2>, IBufferMessage
{
	private static readonly MessageParser<DoGachaScRsp2> _parser = new MessageParser<DoGachaScRsp2>(() => new DoGachaScRsp2());

	private UnknownFieldSet _unknownFields;

	public const int JKAMHIKIBEJFieldNumber = 1;

	private static readonly FieldCodec<GMKCFCGMJKI> _repeated_jKAMHIKIBEJ_codec = FieldCodec.ForMessage(10u, GMKCFCGMJKI.Parser);

	private readonly RepeatedField<GMKCFCGMJKI> jKAMHIKIBEJ_ = new RepeatedField<GMKCFCGMJKI>();

	public const int PKNILEKKIPLFieldNumber = 12;

	private static readonly FieldCodec<OJCKLCKHPLM> _repeated_pKNILEKKIPL_codec = FieldCodec.ForMessage(98u, OJCKLCKHPLM.Parser);

	private readonly RepeatedField<OJCKLCKHPLM> pKNILEKKIPL_ = new RepeatedField<OJCKLCKHPLM>();

	public const int BEDLMDHNMBJFieldNumber = 14;

	private uint bEDLMDHNMBJ_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DoGachaScRsp2> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DoGachaScRsp2Reflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GMKCFCGMJKI> JKAMHIKIBEJ => jKAMHIKIBEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OJCKLCKHPLM> PKNILEKKIPL => pKNILEKKIPL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEDLMDHNMBJ
	{
		get
		{
			return bEDLMDHNMBJ_;
		}
		set
		{
			bEDLMDHNMBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaScRsp2()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaScRsp2(DoGachaScRsp2 other)
		: this()
	{
		jKAMHIKIBEJ_ = other.jKAMHIKIBEJ_.Clone();
		pKNILEKKIPL_ = other.pKNILEKKIPL_.Clone();
		bEDLMDHNMBJ_ = other.bEDLMDHNMBJ_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaScRsp2 Clone()
	{
		return new DoGachaScRsp2(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DoGachaScRsp2);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DoGachaScRsp2 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jKAMHIKIBEJ_.Equals(other.jKAMHIKIBEJ_))
		{
			return false;
		}
		if (!pKNILEKKIPL_.Equals(other.pKNILEKKIPL_))
		{
			return false;
		}
		if (BEDLMDHNMBJ != other.BEDLMDHNMBJ)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= jKAMHIKIBEJ_.GetHashCode();
		num ^= pKNILEKKIPL_.GetHashCode();
		if (BEDLMDHNMBJ != 0)
		{
			num ^= BEDLMDHNMBJ.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		jKAMHIKIBEJ_.WriteTo(ref output, _repeated_jKAMHIKIBEJ_codec);
		pKNILEKKIPL_.WriteTo(ref output, _repeated_pKNILEKKIPL_codec);
		if (BEDLMDHNMBJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BEDLMDHNMBJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		num += jKAMHIKIBEJ_.CalculateSize(_repeated_jKAMHIKIBEJ_codec);
		num += pKNILEKKIPL_.CalculateSize(_repeated_pKNILEKKIPL_codec);
		if (BEDLMDHNMBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEDLMDHNMBJ);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DoGachaScRsp2 other)
	{
		if (other != null)
		{
			jKAMHIKIBEJ_.Add(other.jKAMHIKIBEJ_);
			pKNILEKKIPL_.Add(other.pKNILEKKIPL_);
			if (other.BEDLMDHNMBJ != 0)
			{
				BEDLMDHNMBJ = other.BEDLMDHNMBJ;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 10u:
				jKAMHIKIBEJ_.AddEntriesFrom(ref input, _repeated_jKAMHIKIBEJ_codec);
				break;
			case 98u:
				pKNILEKKIPL_.AddEntriesFrom(ref input, _repeated_pKNILEKKIPL_codec);
				break;
			case 112u:
				BEDLMDHNMBJ = input.ReadUInt32();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
