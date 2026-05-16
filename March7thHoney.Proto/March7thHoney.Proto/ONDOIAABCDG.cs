using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ONDOIAABCDG : IMessage<ONDOIAABCDG>, IMessage, IEquatable<ONDOIAABCDG>, IDeepCloneable<ONDOIAABCDG>, IBufferMessage
{
	private static readonly MessageParser<ONDOIAABCDG> _parser = new MessageParser<ONDOIAABCDG>(() => new ONDOIAABCDG());

	private UnknownFieldSet _unknownFields;

	public const int AMADFJNHMFFFieldNumber = 5;

	private uint aMADFJNHMFF_;

	public const int HOHANPJNANAFieldNumber = 7;

	private uint hOHANPJNANA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ONDOIAABCDG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ONDOIAABCDGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint HOHANPJNANA
	{
		get
		{
			return hOHANPJNANA_;
		}
		set
		{
			hOHANPJNANA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONDOIAABCDG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONDOIAABCDG(ONDOIAABCDG other)
		: this()
	{
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		hOHANPJNANA_ = other.hOHANPJNANA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONDOIAABCDG Clone()
	{
		return new ONDOIAABCDG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ONDOIAABCDG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ONDOIAABCDG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (HOHANPJNANA != other.HOHANPJNANA)
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
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (HOHANPJNANA != 0)
		{
			num ^= HOHANPJNANA.GetHashCode();
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
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (HOHANPJNANA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HOHANPJNANA);
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
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (HOHANPJNANA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOHANPJNANA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ONDOIAABCDG other)
	{
		if (other != null)
		{
			if (other.AMADFJNHMFF != 0)
			{
				AMADFJNHMFF = other.AMADFJNHMFF;
			}
			if (other.HOHANPJNANA != 0)
			{
				HOHANPJNANA = other.HOHANPJNANA;
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
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 56u:
				HOHANPJNANA = input.ReadUInt32();
				break;
			}
		}
	}
}
