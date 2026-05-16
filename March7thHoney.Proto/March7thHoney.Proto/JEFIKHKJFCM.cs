using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JEFIKHKJFCM : IMessage<JEFIKHKJFCM>, IMessage, IEquatable<JEFIKHKJFCM>, IDeepCloneable<JEFIKHKJFCM>, IBufferMessage
{
	private static readonly MessageParser<JEFIKHKJFCM> _parser = new MessageParser<JEFIKHKJFCM>(() => new JEFIKHKJFCM());

	private UnknownFieldSet _unknownFields;

	public const int HOKJFKNPKAJFieldNumber = 5;

	private uint hOKJFKNPKAJ_;

	public const int FCADJEENGMLFieldNumber = 15;

	private uint fCADJEENGML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JEFIKHKJFCM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JEFIKHKJFCMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOKJFKNPKAJ
	{
		get
		{
			return hOKJFKNPKAJ_;
		}
		set
		{
			hOKJFKNPKAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCADJEENGML
	{
		get
		{
			return fCADJEENGML_;
		}
		set
		{
			fCADJEENGML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEFIKHKJFCM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEFIKHKJFCM(JEFIKHKJFCM other)
		: this()
	{
		hOKJFKNPKAJ_ = other.hOKJFKNPKAJ_;
		fCADJEENGML_ = other.fCADJEENGML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEFIKHKJFCM Clone()
	{
		return new JEFIKHKJFCM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JEFIKHKJFCM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JEFIKHKJFCM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HOKJFKNPKAJ != other.HOKJFKNPKAJ)
		{
			return false;
		}
		if (FCADJEENGML != other.FCADJEENGML)
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
		if (HOKJFKNPKAJ != 0)
		{
			num ^= HOKJFKNPKAJ.GetHashCode();
		}
		if (FCADJEENGML != 0)
		{
			num ^= FCADJEENGML.GetHashCode();
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
		if (HOKJFKNPKAJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HOKJFKNPKAJ);
		}
		if (FCADJEENGML != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FCADJEENGML);
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
		if (HOKJFKNPKAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOKJFKNPKAJ);
		}
		if (FCADJEENGML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCADJEENGML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JEFIKHKJFCM other)
	{
		if (other != null)
		{
			if (other.HOKJFKNPKAJ != 0)
			{
				HOKJFKNPKAJ = other.HOKJFKNPKAJ;
			}
			if (other.FCADJEENGML != 0)
			{
				FCADJEENGML = other.FCADJEENGML;
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
			case 40u:
				HOKJFKNPKAJ = input.ReadUInt32();
				break;
			case 120u:
				FCADJEENGML = input.ReadUInt32();
				break;
			}
		}
	}
}
