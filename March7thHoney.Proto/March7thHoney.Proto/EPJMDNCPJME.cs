using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EPJMDNCPJME : IMessage<EPJMDNCPJME>, IMessage, IEquatable<EPJMDNCPJME>, IDeepCloneable<EPJMDNCPJME>, IBufferMessage
{
	private static readonly MessageParser<EPJMDNCPJME> _parser = new MessageParser<EPJMDNCPJME>(() => new EPJMDNCPJME());

	private UnknownFieldSet _unknownFields;

	public const int FIMNPEBOBHLFieldNumber = 2;

	private uint fIMNPEBOBHL_;

	public const int ProgressFieldNumber = 4;

	private uint progress_;

	public const int SourceFieldNumber = 7;

	private MCAFGBPLFEH source_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EPJMDNCPJME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EPJMDNCPJMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIMNPEBOBHL
	{
		get
		{
			return fIMNPEBOBHL_;
		}
		set
		{
			fIMNPEBOBHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMDNCPJME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMDNCPJME(EPJMDNCPJME other)
		: this()
	{
		fIMNPEBOBHL_ = other.fIMNPEBOBHL_;
		progress_ = other.progress_;
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPJMDNCPJME Clone()
	{
		return new EPJMDNCPJME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EPJMDNCPJME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EPJMDNCPJME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FIMNPEBOBHL != other.FIMNPEBOBHL)
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (!object.Equals(Source, other.Source))
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
		if (FIMNPEBOBHL != 0)
		{
			num ^= FIMNPEBOBHL.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
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
		if (FIMNPEBOBHL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FIMNPEBOBHL);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Progress);
		}
		if (source_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Source);
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
		if (FIMNPEBOBHL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIMNPEBOBHL);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EPJMDNCPJME other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FIMNPEBOBHL != 0)
		{
			FIMNPEBOBHL = other.FIMNPEBOBHL;
		}
		if (other.Progress != 0)
		{
			Progress = other.Progress;
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new MCAFGBPLFEH();
			}
			Source.MergeFrom(other.Source);
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
			case 16u:
				FIMNPEBOBHL = input.ReadUInt32();
				break;
			case 32u:
				Progress = input.ReadUInt32();
				break;
			case 58u:
				if (source_ == null)
				{
					Source = new MCAFGBPLFEH();
				}
				input.ReadMessage(Source);
				break;
			}
		}
	}
}
