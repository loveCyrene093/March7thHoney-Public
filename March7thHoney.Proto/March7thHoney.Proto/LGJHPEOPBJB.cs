using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGJHPEOPBJB : IMessage<LGJHPEOPBJB>, IMessage, IEquatable<LGJHPEOPBJB>, IDeepCloneable<LGJHPEOPBJB>, IBufferMessage
{
	private static readonly MessageParser<LGJHPEOPBJB> _parser = new MessageParser<LGJHPEOPBJB>(() => new LGJHPEOPBJB());

	private UnknownFieldSet _unknownFields;

	public const int GachaRandomFieldNumber = 1;

	private uint gachaRandom_;

	public const int JOOLIKGDJJFFieldNumber = 7;

	private uint jOOLIKGDJJF_;

	public const int NJELGEBHAOPFieldNumber = 8;

	private OBECBMMMDHC nJELGEBHAOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGJHPEOPBJB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGJHPEOPBJBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaRandom
	{
		get
		{
			return gachaRandom_;
		}
		set
		{
			gachaRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JOOLIKGDJJF
	{
		get
		{
			return jOOLIKGDJJF_;
		}
		set
		{
			jOOLIKGDJJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBECBMMMDHC NJELGEBHAOP
	{
		get
		{
			return nJELGEBHAOP_;
		}
		set
		{
			nJELGEBHAOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGJHPEOPBJB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGJHPEOPBJB(LGJHPEOPBJB other)
		: this()
	{
		gachaRandom_ = other.gachaRandom_;
		jOOLIKGDJJF_ = other.jOOLIKGDJJF_;
		nJELGEBHAOP_ = ((other.nJELGEBHAOP_ != null) ? other.nJELGEBHAOP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGJHPEOPBJB Clone()
	{
		return new LGJHPEOPBJB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGJHPEOPBJB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGJHPEOPBJB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaRandom != other.GachaRandom)
		{
			return false;
		}
		if (JOOLIKGDJJF != other.JOOLIKGDJJF)
		{
			return false;
		}
		if (!object.Equals(NJELGEBHAOP, other.NJELGEBHAOP))
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
		if (GachaRandom != 0)
		{
			num ^= GachaRandom.GetHashCode();
		}
		if (JOOLIKGDJJF != 0)
		{
			num ^= JOOLIKGDJJF.GetHashCode();
		}
		if (nJELGEBHAOP_ != null)
		{
			num ^= NJELGEBHAOP.GetHashCode();
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
		if (GachaRandom != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GachaRandom);
		}
		if (JOOLIKGDJJF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JOOLIKGDJJF);
		}
		if (nJELGEBHAOP_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(NJELGEBHAOP);
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
		if (GachaRandom != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaRandom);
		}
		if (JOOLIKGDJJF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JOOLIKGDJJF);
		}
		if (nJELGEBHAOP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NJELGEBHAOP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGJHPEOPBJB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GachaRandom != 0)
		{
			GachaRandom = other.GachaRandom;
		}
		if (other.JOOLIKGDJJF != 0)
		{
			JOOLIKGDJJF = other.JOOLIKGDJJF;
		}
		if (other.nJELGEBHAOP_ != null)
		{
			if (nJELGEBHAOP_ == null)
			{
				NJELGEBHAOP = new OBECBMMMDHC();
			}
			NJELGEBHAOP.MergeFrom(other.NJELGEBHAOP);
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
			case 8u:
				GachaRandom = input.ReadUInt32();
				break;
			case 56u:
				JOOLIKGDJJF = input.ReadUInt32();
				break;
			case 66u:
				if (nJELGEBHAOP_ == null)
				{
					NJELGEBHAOP = new OBECBMMMDHC();
				}
				input.ReadMessage(NJELGEBHAOP);
				break;
			}
		}
	}
}
