using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJCIJFPNPKF : IMessage<OJCIJFPNPKF>, IMessage, IEquatable<OJCIJFPNPKF>, IDeepCloneable<OJCIJFPNPKF>, IBufferMessage
{
	private static readonly MessageParser<OJCIJFPNPKF> _parser = new MessageParser<OJCIJFPNPKF>(() => new OJCIJFPNPKF());

	private UnknownFieldSet _unknownFields;

	public const int CHCGMAMOBMHFieldNumber = 6;

	private bool cHCGMAMOBMH_;

	public const int AMADFJNHMFFFieldNumber = 14;

	private uint aMADFJNHMFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJCIJFPNPKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJCIJFPNPKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCGMAMOBMH
	{
		get
		{
			return cHCGMAMOBMH_;
		}
		set
		{
			cHCGMAMOBMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMADFJNHMFF
	{
		get
		{
			return aMADFJNHMFF_;
		}
		set
		{
			aMADFJNHMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJCIJFPNPKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJCIJFPNPKF(OJCIJFPNPKF other)
		: this()
	{
		cHCGMAMOBMH_ = other.cHCGMAMOBMH_;
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJCIJFPNPKF Clone()
	{
		return new OJCIJFPNPKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJCIJFPNPKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJCIJFPNPKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHCGMAMOBMH != other.CHCGMAMOBMH)
		{
			return false;
		}
		if (AMADFJNHMFF != other.AMADFJNHMFF)
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
		if (CHCGMAMOBMH)
		{
			num ^= CHCGMAMOBMH.GetHashCode();
		}
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
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
		if (CHCGMAMOBMH)
		{
			output.WriteRawTag(48);
			output.WriteBool(CHCGMAMOBMH);
		}
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AMADFJNHMFF);
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
		if (CHCGMAMOBMH)
		{
			num += 2;
		}
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJCIJFPNPKF other)
	{
		if (other != null)
		{
			if (other.CHCGMAMOBMH)
			{
				CHCGMAMOBMH = other.CHCGMAMOBMH;
			}
			if (other.AMADFJNHMFF != 0)
			{
				AMADFJNHMFF = other.AMADFJNHMFF;
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
				CHCGMAMOBMH = input.ReadBool();
				break;
			case 112u:
				AMADFJNHMFF = input.ReadUInt32();
				break;
			}
		}
	}
}
