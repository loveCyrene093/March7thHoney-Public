using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNOCKAECKII : IMessage<KNOCKAECKII>, IMessage, IEquatable<KNOCKAECKII>, IDeepCloneable<KNOCKAECKII>, IBufferMessage
{
	private static readonly MessageParser<KNOCKAECKII> _parser = new MessageParser<KNOCKAECKII>(() => new KNOCKAECKII());

	private UnknownFieldSet _unknownFields;

	public const int LFMKDJEOIGIFieldNumber = 3;

	private BDDBAKBOMKP lFMKDJEOIGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNOCKAECKII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNOCKAECKIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDDBAKBOMKP LFMKDJEOIGI
	{
		get
		{
			return lFMKDJEOIGI_;
		}
		set
		{
			lFMKDJEOIGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNOCKAECKII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNOCKAECKII(KNOCKAECKII other)
		: this()
	{
		lFMKDJEOIGI_ = ((other.lFMKDJEOIGI_ != null) ? other.lFMKDJEOIGI_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNOCKAECKII Clone()
	{
		return new KNOCKAECKII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KNOCKAECKII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNOCKAECKII other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LFMKDJEOIGI, other.LFMKDJEOIGI))
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
		if (lFMKDJEOIGI_ != null)
		{
			num ^= LFMKDJEOIGI.GetHashCode();
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
		if (lFMKDJEOIGI_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LFMKDJEOIGI);
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
		if (lFMKDJEOIGI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LFMKDJEOIGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNOCKAECKII other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lFMKDJEOIGI_ != null)
		{
			if (lFMKDJEOIGI_ == null)
			{
				LFMKDJEOIGI = new BDDBAKBOMKP();
			}
			LFMKDJEOIGI.MergeFrom(other.LFMKDJEOIGI);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (lFMKDJEOIGI_ == null)
			{
				LFMKDJEOIGI = new BDDBAKBOMKP();
			}
			input.ReadMessage(LFMKDJEOIGI);
		}
	}
}
