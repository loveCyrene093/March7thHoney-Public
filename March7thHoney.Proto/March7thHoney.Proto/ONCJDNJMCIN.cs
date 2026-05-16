using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ONCJDNJMCIN : IMessage<ONCJDNJMCIN>, IMessage, IEquatable<ONCJDNJMCIN>, IDeepCloneable<ONCJDNJMCIN>, IBufferMessage
{
	private static readonly MessageParser<ONCJDNJMCIN> _parser = new MessageParser<ONCJDNJMCIN>(() => new ONCJDNJMCIN());

	private UnknownFieldSet _unknownFields;

	public const int FBJLNMOIFIBFieldNumber = 4;

	private bool fBJLNMOIFIB_;

	public const int MAFMCIPAIKKFieldNumber = 6;

	private uint mAFMCIPAIKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ONCJDNJMCIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ONCJDNJMCINReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FBJLNMOIFIB
	{
		get
		{
			return fBJLNMOIFIB_;
		}
		set
		{
			fBJLNMOIFIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAFMCIPAIKK
	{
		get
		{
			return mAFMCIPAIKK_;
		}
		set
		{
			mAFMCIPAIKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONCJDNJMCIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONCJDNJMCIN(ONCJDNJMCIN other)
		: this()
	{
		fBJLNMOIFIB_ = other.fBJLNMOIFIB_;
		mAFMCIPAIKK_ = other.mAFMCIPAIKK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONCJDNJMCIN Clone()
	{
		return new ONCJDNJMCIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ONCJDNJMCIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ONCJDNJMCIN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FBJLNMOIFIB != other.FBJLNMOIFIB)
		{
			return false;
		}
		if (MAFMCIPAIKK != other.MAFMCIPAIKK)
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
		if (FBJLNMOIFIB)
		{
			num ^= FBJLNMOIFIB.GetHashCode();
		}
		if (MAFMCIPAIKK != 0)
		{
			num ^= MAFMCIPAIKK.GetHashCode();
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
		if (FBJLNMOIFIB)
		{
			output.WriteRawTag(32);
			output.WriteBool(FBJLNMOIFIB);
		}
		if (MAFMCIPAIKK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MAFMCIPAIKK);
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
		if (FBJLNMOIFIB)
		{
			num += 2;
		}
		if (MAFMCIPAIKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAFMCIPAIKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ONCJDNJMCIN other)
	{
		if (other != null)
		{
			if (other.FBJLNMOIFIB)
			{
				FBJLNMOIFIB = other.FBJLNMOIFIB;
			}
			if (other.MAFMCIPAIKK != 0)
			{
				MAFMCIPAIKK = other.MAFMCIPAIKK;
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
				FBJLNMOIFIB = input.ReadBool();
				break;
			case 48u:
				MAFMCIPAIKK = input.ReadUInt32();
				break;
			}
		}
	}
}
