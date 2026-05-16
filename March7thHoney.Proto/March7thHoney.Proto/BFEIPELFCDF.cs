using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BFEIPELFCDF : IMessage<BFEIPELFCDF>, IMessage, IEquatable<BFEIPELFCDF>, IDeepCloneable<BFEIPELFCDF>, IBufferMessage
{
	private static readonly MessageParser<BFEIPELFCDF> _parser = new MessageParser<BFEIPELFCDF>(() => new BFEIPELFCDF());

	private UnknownFieldSet _unknownFields;

	public const int SceneFieldNumber = 2;

	private SceneInfo scene_;

	public const int LineupFieldNumber = 8;

	private LineupInfo lineup_;

	public const int ENPAICNLCMKFieldNumber = 14;

	private MADEENABOKE eNPAICNLCMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BFEIPELFCDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BFEIPELFCDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneInfo Scene
	{
		get
		{
			return scene_;
		}
		set
		{
			scene_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MADEENABOKE ENPAICNLCMK
	{
		get
		{
			return eNPAICNLCMK_;
		}
		set
		{
			eNPAICNLCMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFEIPELFCDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFEIPELFCDF(BFEIPELFCDF other)
		: this()
	{
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		eNPAICNLCMK_ = ((other.eNPAICNLCMK_ != null) ? other.eNPAICNLCMK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFEIPELFCDF Clone()
	{
		return new BFEIPELFCDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BFEIPELFCDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BFEIPELFCDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Scene, other.Scene))
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!object.Equals(ENPAICNLCMK, other.ENPAICNLCMK))
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
		if (scene_ != null)
		{
			num ^= Scene.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (eNPAICNLCMK_ != null)
		{
			num ^= ENPAICNLCMK.GetHashCode();
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
		if (scene_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Scene);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Lineup);
		}
		if (eNPAICNLCMK_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ENPAICNLCMK);
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
		if (scene_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scene);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (eNPAICNLCMK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENPAICNLCMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BFEIPELFCDF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.scene_ != null)
		{
			if (scene_ == null)
			{
				Scene = new SceneInfo();
			}
			Scene.MergeFrom(other.Scene);
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new LineupInfo();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.eNPAICNLCMK_ != null)
		{
			if (eNPAICNLCMK_ == null)
			{
				ENPAICNLCMK = new MADEENABOKE();
			}
			ENPAICNLCMK.MergeFrom(other.ENPAICNLCMK);
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
			case 18u:
				if (scene_ == null)
				{
					Scene = new SceneInfo();
				}
				input.ReadMessage(Scene);
				break;
			case 66u:
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 114u:
				if (eNPAICNLCMK_ == null)
				{
					ENPAICNLCMK = new MADEENABOKE();
				}
				input.ReadMessage(ENPAICNLCMK);
				break;
			}
		}
	}
}
