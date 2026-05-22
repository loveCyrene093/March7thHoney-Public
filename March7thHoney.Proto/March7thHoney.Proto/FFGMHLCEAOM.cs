using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFGMHLCEAOM : IMessage<FFGMHLCEAOM>, IMessage, IEquatable<FFGMHLCEAOM>, IDeepCloneable<FFGMHLCEAOM>, IBufferMessage
{
	private static readonly MessageParser<FFGMHLCEAOM> _parser = new MessageParser<FFGMHLCEAOM>(() => new FFGMHLCEAOM());

	private UnknownFieldSet _unknownFields;

	public const int HGFBBIBBCNEFieldNumber = 11;

	private uint hGFBBIBBCNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFGMHLCEAOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFGMHLCEAOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HGFBBIBBCNE
	{
		get
		{
			return hGFBBIBBCNE_;
		}
		set
		{
			hGFBBIBBCNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFGMHLCEAOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFGMHLCEAOM(FFGMHLCEAOM other)
		: this()
	{
		hGFBBIBBCNE_ = other.hGFBBIBBCNE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFGMHLCEAOM Clone()
	{
		return new FFGMHLCEAOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFGMHLCEAOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFGMHLCEAOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HGFBBIBBCNE != other.HGFBBIBBCNE)
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
		if (HGFBBIBBCNE != 0)
		{
			num ^= HGFBBIBBCNE.GetHashCode();
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
		if (HGFBBIBBCNE != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HGFBBIBBCNE);
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
		if (HGFBBIBBCNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HGFBBIBBCNE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FFGMHLCEAOM other)
	{
		if (other != null)
		{
			if (other.HGFBBIBBCNE != 0)
			{
				HGFBBIBBCNE = other.HGFBBIBBCNE;
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
				HGFBBIBBCNE = input.ReadUInt32();
			}
		}
	}
}
