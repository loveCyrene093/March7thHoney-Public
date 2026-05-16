using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HFBFFEBOAHL : IMessage<HFBFFEBOAHL>, IMessage, IEquatable<HFBFFEBOAHL>, IDeepCloneable<HFBFFEBOAHL>, IBufferMessage
{
	private static readonly MessageParser<HFBFFEBOAHL> _parser = new MessageParser<HFBFFEBOAHL>(() => new HFBFFEBOAHL());

	private UnknownFieldSet _unknownFields;

	public const int DNNHCNCKJCMFieldNumber = 4;

	private long dNNHCNCKJCM_;

	public const int HPJLNIPAHCHFieldNumber = 12;

	private long hPJLNIPAHCH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HFBFFEBOAHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HFBFFEBOAHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DNNHCNCKJCM
	{
		get
		{
			return dNNHCNCKJCM_;
		}
		set
		{
			dNNHCNCKJCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long HPJLNIPAHCH
	{
		get
		{
			return hPJLNIPAHCH_;
		}
		set
		{
			hPJLNIPAHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFBFFEBOAHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFBFFEBOAHL(HFBFFEBOAHL other)
		: this()
	{
		dNNHCNCKJCM_ = other.dNNHCNCKJCM_;
		hPJLNIPAHCH_ = other.hPJLNIPAHCH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFBFFEBOAHL Clone()
	{
		return new HFBFFEBOAHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HFBFFEBOAHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HFBFFEBOAHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DNNHCNCKJCM != other.DNNHCNCKJCM)
		{
			return false;
		}
		if (HPJLNIPAHCH != other.HPJLNIPAHCH)
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
		if (DNNHCNCKJCM != 0L)
		{
			num ^= DNNHCNCKJCM.GetHashCode();
		}
		if (HPJLNIPAHCH != 0L)
		{
			num ^= HPJLNIPAHCH.GetHashCode();
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
		if (DNNHCNCKJCM != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(DNNHCNCKJCM);
		}
		if (HPJLNIPAHCH != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(HPJLNIPAHCH);
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
		if (DNNHCNCKJCM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DNNHCNCKJCM);
		}
		if (HPJLNIPAHCH != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(HPJLNIPAHCH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HFBFFEBOAHL other)
	{
		if (other != null)
		{
			if (other.DNNHCNCKJCM != 0L)
			{
				DNNHCNCKJCM = other.DNNHCNCKJCM;
			}
			if (other.HPJLNIPAHCH != 0L)
			{
				HPJLNIPAHCH = other.HPJLNIPAHCH;
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
				DNNHCNCKJCM = input.ReadInt64();
				break;
			case 96u:
				HPJLNIPAHCH = input.ReadInt64();
				break;
			}
		}
	}
}
