using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OFCENAHFFEN : IMessage<OFCENAHFFEN>, IMessage, IEquatable<OFCENAHFFEN>, IDeepCloneable<OFCENAHFFEN>, IBufferMessage
{
	private static readonly MessageParser<OFCENAHFFEN> _parser = new MessageParser<OFCENAHFFEN>(() => new OFCENAHFFEN());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int HFLCLFLCCLKFieldNumber = 11;

	private MainMission hFLCLFLCCLK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OFCENAHFFEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OFCENAHFFENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMission HFLCLFLCCLK
	{
		get
		{
			return hFLCLFLCCLK_;
		}
		set
		{
			hFLCLFLCCLK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFCENAHFFEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFCENAHFFEN(OFCENAHFFEN other)
		: this()
	{
		retcode_ = other.retcode_;
		hFLCLFLCCLK_ = ((other.hFLCLFLCCLK_ != null) ? other.hFLCLFLCCLK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFCENAHFFEN Clone()
	{
		return new OFCENAHFFEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OFCENAHFFEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OFCENAHFFEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(HFLCLFLCCLK, other.HFLCLFLCCLK))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (hFLCLFLCCLK_ != null)
		{
			num ^= HFLCLFLCCLK.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (hFLCLFLCCLK_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(HFLCLFLCCLK);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (hFLCLFLCCLK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HFLCLFLCCLK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OFCENAHFFEN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.hFLCLFLCCLK_ != null)
		{
			if (hFLCLFLCCLK_ == null)
			{
				HFLCLFLCCLK = new MainMission();
			}
			HFLCLFLCCLK.MergeFrom(other.HFLCLFLCCLK);
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
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (hFLCLFLCCLK_ == null)
				{
					HFLCLFLCCLK = new MainMission();
				}
				input.ReadMessage(HFLCLFLCCLK);
				break;
			}
		}
	}
}
