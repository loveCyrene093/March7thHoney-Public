using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAAMEJNMMOB : IMessage<BAAMEJNMMOB>, IMessage, IEquatable<BAAMEJNMMOB>, IDeepCloneable<BAAMEJNMMOB>, IBufferMessage
{
	private static readonly MessageParser<BAAMEJNMMOB> _parser = new MessageParser<BAAMEJNMMOB>(() => new BAAMEJNMMOB());

	private UnknownFieldSet _unknownFields;

	public const int PKIDNPPFBIOFieldNumber = 11;

	private uint pKIDNPPFBIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAAMEJNMMOB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAAMEJNMMOBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKIDNPPFBIO
	{
		get
		{
			return pKIDNPPFBIO_;
		}
		set
		{
			pKIDNPPFBIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAMEJNMMOB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAMEJNMMOB(BAAMEJNMMOB other)
		: this()
	{
		pKIDNPPFBIO_ = other.pKIDNPPFBIO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAAMEJNMMOB Clone()
	{
		return new BAAMEJNMMOB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAAMEJNMMOB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAAMEJNMMOB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PKIDNPPFBIO != other.PKIDNPPFBIO)
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
		if (PKIDNPPFBIO != 0)
		{
			num ^= PKIDNPPFBIO.GetHashCode();
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
		if (PKIDNPPFBIO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PKIDNPPFBIO);
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
		if (PKIDNPPFBIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKIDNPPFBIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BAAMEJNMMOB other)
	{
		if (other != null)
		{
			if (other.PKIDNPPFBIO != 0)
			{
				PKIDNPPFBIO = other.PKIDNPPFBIO;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PKIDNPPFBIO = input.ReadUInt32();
			}
		}
	}
}
