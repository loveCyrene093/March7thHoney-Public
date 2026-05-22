using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HCDIHOBPLJE : IMessage<HCDIHOBPLJE>, IMessage, IEquatable<HCDIHOBPLJE>, IDeepCloneable<HCDIHOBPLJE>, IBufferMessage
{
	private static readonly MessageParser<HCDIHOBPLJE> _parser = new MessageParser<HCDIHOBPLJE>(() => new HCDIHOBPLJE());

	private UnknownFieldSet _unknownFields;

	public const int CNPONFMAKJOFieldNumber = 13;

	private uint cNPONFMAKJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HCDIHOBPLJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HCDIHOBPLJEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CNPONFMAKJO
	{
		get
		{
			return cNPONFMAKJO_;
		}
		set
		{
			cNPONFMAKJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCDIHOBPLJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCDIHOBPLJE(HCDIHOBPLJE other)
		: this()
	{
		cNPONFMAKJO_ = other.cNPONFMAKJO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCDIHOBPLJE Clone()
	{
		return new HCDIHOBPLJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HCDIHOBPLJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HCDIHOBPLJE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CNPONFMAKJO != other.CNPONFMAKJO)
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
		if (CNPONFMAKJO != 0)
		{
			num ^= CNPONFMAKJO.GetHashCode();
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
		if (CNPONFMAKJO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CNPONFMAKJO);
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
		if (CNPONFMAKJO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CNPONFMAKJO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HCDIHOBPLJE other)
	{
		if (other != null)
		{
			if (other.CNPONFMAKJO != 0)
			{
				CNPONFMAKJO = other.CNPONFMAKJO;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CNPONFMAKJO = input.ReadUInt32();
			}
		}
	}
}
