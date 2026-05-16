using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EBGJKPJNPBL : IMessage<EBGJKPJNPBL>, IMessage, IEquatable<EBGJKPJNPBL>, IDeepCloneable<EBGJKPJNPBL>, IBufferMessage
{
	private static readonly MessageParser<EBGJKPJNPBL> _parser = new MessageParser<EBGJKPJNPBL>(() => new EBGJKPJNPBL());

	private UnknownFieldSet _unknownFields;

	public const int IMGGIEHBABMFieldNumber = 1;

	private uint iMGGIEHBABM_;

	public const int DDPKJKHEDLHFieldNumber = 2;

	private static readonly FieldCodec<NAKIGLPGKBA> _repeated_dDPKJKHEDLH_codec = FieldCodec.ForMessage(18u, NAKIGLPGKBA.Parser);

	private readonly RepeatedField<NAKIGLPGKBA> dDPKJKHEDLH_ = new RepeatedField<NAKIGLPGKBA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EBGJKPJNPBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EBGJKPJNPBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMGGIEHBABM
	{
		get
		{
			return iMGGIEHBABM_;
		}
		set
		{
			iMGGIEHBABM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NAKIGLPGKBA> DDPKJKHEDLH => dDPKJKHEDLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBGJKPJNPBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBGJKPJNPBL(EBGJKPJNPBL other)
		: this()
	{
		iMGGIEHBABM_ = other.iMGGIEHBABM_;
		dDPKJKHEDLH_ = other.dDPKJKHEDLH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBGJKPJNPBL Clone()
	{
		return new EBGJKPJNPBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EBGJKPJNPBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EBGJKPJNPBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IMGGIEHBABM != other.IMGGIEHBABM)
		{
			return false;
		}
		if (!dDPKJKHEDLH_.Equals(other.dDPKJKHEDLH_))
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
		if (IMGGIEHBABM != 0)
		{
			num ^= IMGGIEHBABM.GetHashCode();
		}
		num ^= dDPKJKHEDLH_.GetHashCode();
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
		if (IMGGIEHBABM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IMGGIEHBABM);
		}
		dDPKJKHEDLH_.WriteTo(ref output, _repeated_dDPKJKHEDLH_codec);
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
		if (IMGGIEHBABM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMGGIEHBABM);
		}
		num += dDPKJKHEDLH_.CalculateSize(_repeated_dDPKJKHEDLH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EBGJKPJNPBL other)
	{
		if (other != null)
		{
			if (other.IMGGIEHBABM != 0)
			{
				IMGGIEHBABM = other.IMGGIEHBABM;
			}
			dDPKJKHEDLH_.Add(other.dDPKJKHEDLH_);
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
				IMGGIEHBABM = input.ReadUInt32();
				break;
			case 18u:
				dDPKJKHEDLH_.AddEntriesFrom(ref input, _repeated_dDPKJKHEDLH_codec);
				break;
			}
		}
	}
}
